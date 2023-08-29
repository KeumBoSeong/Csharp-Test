using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;

namespace Min_Project
{
    public class Management
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Major { get; set; }
        public string Lecture { get; set; }
        public string Grade { get; set; }
    }
    public class ManagementContext : DbContext
    {
        public DbSet<Management> Management { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=c##scott;Password=tiger;Data Source=127.0.0.1/XE;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Management>()   //Primary key 지정
            //    .HasKey(p => p.ID);
            //modelBuilder.Entity<Management>()   //Varchar2(30) 30크기를 정할 때
            //    .Property(p => p.Name)
            //    .HasMaxLength(30);
            //modelBuilder.Entity<Management>()
            //    .Property(p => p.Year);
            //modelBuilder.Entity<Management>()
            //    .Property(p => p.Major)
            //    .HasMaxLength(30);
            //modelBuilder.Entity<Management>()
            //    .Property(p => p.Lecture)
            //    .HasMaxLength(30);
            //modelBuilder.Entity<Management>()
            //    .Property(p => p.Grade)
            //    .HasMaxLength(30);
        }
    }

    internal class Program
    {
        private static int N;
        static void UIinit()
        {
            Console.WriteLine("1. 데이터 삽입");
            Console.WriteLine("2. 데이터 삭제");
            Console.WriteLine("3. 데이터 수정");
            Console.WriteLine("4. 데이터 검색");
            Console.WriteLine("5. 프로그램 종료");

            Console.Write("메뉴의 번호를 입력하세요 : ");
            N = int.Parse(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            string asciiArt = @"#     #                                                               
##   ##   ##   #    #   ##    ####  ###### #    # ###### #    # ##### 
# # # #  #  #  ##   #  #  #  #    # #      ##  ## #      ##   #   #   
#  #  # #    # # #  # #    # #      #####  # ## # #####  # #  #   #   
#     # ###### #  # # ###### #  ### #      #    # #      #  # #   #   
#     # #    # #   ## #    # #    # #      #    # #      #   ##   #   
#     # #    # #    # #    #  ####  ###### #    # ###### #    #   #   
                                                                      ";
            Console.WriteLine(asciiArt);

            while (true)
            {
                UIinit();
                switch (N)
                {
                    case 1:
                        using (var context = new ManagementContext())
                        {
                            Console.Write("학번을 입력하세요 : ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("이름을 입력하세요 : ");
                            string name = Console.ReadLine();
                            Console.Write("학년을 입력하세요 : ");
                            int year = int.Parse(Console.ReadLine());
                            Console.Write("전공을 입력하세요 : ");
                            string major = Console.ReadLine();
                            Console.Write("강의명을 입력하세요 : ");
                            string lecture = Console.ReadLine();
                            Console.Write("성적을 입력하세요 : ");
                            string grade = Console.ReadLine();
                            Console.WriteLine("데이터 삽입중...");

                            var manage = new Management
                            {
                                ID = id,
                                Name = name,
                                Year = year,
                                Major = major,
                                Lecture = lecture,
                                Grade = grade
                            };
                            context.Management.AddRange(manage);
                            context.SaveChanges();
                            Console.WriteLine("!!데이터 삽입 성공!!");
                        }
                        break;
                    case 2:
                        using (var context = new ManagementContext())
                        {
                            Console.Write("삭제할 데이터의 이름을 입력하세요 : ");
                            var ManagementToDelete = context.Management.FirstOrDefault(p => p.Name == Console.ReadLine());

                            if (ManagementToDelete != null)
                            {
                                Console.WriteLine("데이터 삭제중...");
                                context.Management.Remove(ManagementToDelete);

                                context.SaveChanges();
                                Console.WriteLine("!데이터 삭제 성공!");
                            }
                            else
                            {
                                Console.WriteLine("해당 데이터를 찾을 수 없습니다.");
                            }
                        }
                        break;
                    case 3:
                        using (var context = new ManagementContext())
                        {
                            Console.Write("수정할 데이터의 이름을 입력하세요 : ");
                            var ManagementToEdit = context.Management.FirstOrDefault(p => p.Name == Console.ReadLine());

                            if (ManagementToEdit != null)
                            {
                                string lecture = Console.ReadLine();
                                Console.Write("성적을 입력하세요 : ");
                                string grade = Console.ReadLine();
                                Console.WriteLine("데이터 수정중...");


                                ManagementToEdit.Lecture = lecture;
                                ManagementToEdit.Grade = grade;


                                context.SaveChanges();
                                Console.WriteLine("!!데이터 수정 성공!!");
                            }
                            else
                            {
                                Console.WriteLine("해당 데이터를 찾을 수 없습니다.");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("1. 학번으로 데이터 조회하기");
                        Console.WriteLine("2. 이름으로 데이터 조회하기");
                        Console.WriteLine("3. 전체 데이터 조회하기");

                        Console.Write("번호를 입력하세요 :");
                        int Sub = int.Parse(Console.ReadLine());
                        switch (Sub)
                        {
                            case 1:
                                using (var context = new ManagementContext())
                                {
                                    Console.Write("조회할 데이터의 학번을 입력하세요 : ");
                                    var ManagementToView = context.Management.FirstOrDefault(p => p.ID == int.Parse(Console.ReadLine()));
                                    if (ManagementToView != null)
                                    {
                                        Console.WriteLine($"학번 :{ManagementToView.ID}");
                                        Console.WriteLine($"이름 :{ManagementToView.Name}");
                                        Console.WriteLine($"학년 :{ManagementToView.Year}");
                                        Console.WriteLine($"전공 :{ManagementToView.Major}");
                                        Console.WriteLine($"강의명 :{ManagementToView.Lecture}");
                                        Console.WriteLine($"성적 :{ManagementToView.Grade}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("해당 데이터를 찾을 수 없습니다.");
                                    }
                                }
                                break;
                            case 2:
                                using (var context = new ManagementContext())
                                {
                                    Console.Write("조회할 데이터의 이름을 입력하세요 : ");
                                    var ManagementToView = context.Management.FirstOrDefault(p => p.Name == Console.ReadLine());
                                    if (ManagementToView != null)
                                    {
                                        Console.WriteLine($"학번 :{ManagementToView.ID}");
                                        Console.WriteLine($"이름 :{ManagementToView.Name}");
                                        Console.WriteLine($"학년 :{ManagementToView.Year}");
                                        Console.WriteLine($"전공 :{ManagementToView.Major}");
                                        Console.WriteLine($"강의명 :{ManagementToView.Lecture}");
                                        Console.WriteLine($"성적 :{ManagementToView.Grade}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("해당 데이터를 찾을 수 없습니다.");
                                    }
                                }
                                break;

                            case 3:
                                using (var context = new ManagementContext())
                                {

                                    var manage = context.Management.ToList();
                                    Console.WriteLine($"{nameof(Management.ID)} " +
                                        $"{nameof(Management.Name)} " +
                                        $"{nameof(Management.Year)} " +
                                        $"{nameof(Management.Major)} " +
                                        $"{nameof(Management.Lecture)} " +
                                        $"{nameof(Management.Grade)}");

                                    foreach (var m in manage)
                                    {
                                        Console.WriteLine($"{m.ID} " +
                                            $"{m.Name} " +
                                            $"{m.Year} " +
                                            $"{m.Major} " +
                                            $"{m.Lecture} " +
                                            $"{m.Grade}");
                                    }
                                }
                            break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("\n 프로그램을 종료합니다.\n");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n잘못된 메뉴를 입력하셨습니다.\n");
                        break;
                }
            }
        }
    }
}
