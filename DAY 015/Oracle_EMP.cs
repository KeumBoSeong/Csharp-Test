using Oracle.ManagedDataAccess.Client;
using System;
using System.Xml.Linq;

namespace Oracle_EMP
 //EMP 테이블의 모든 정보를 콘솔화면에 출력.
 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SELECT 데이터 조회
            string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=hr;Password=hr;";

            //1.연결 객체 만들기 - Client
            OracleConnection conn = new OracleConnection(strConn);

            //2.데이터베이스 접속을 위한 연결
            conn.Open();

            //명령객체 생성
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            //데이터 조회
            cmd.CommandText = "SELECT EMPNO, ENAME, JOB, HIREDATE, SAL, DEPTNO FROM EMP";
            //cmd.ExecuteNonQuery()

            //데이터 조회 결과를 리턴하는 DataReader객체를 만들어야 한다.
            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //int id = rdr.GetInt32(0); //int나 number로 받을때 
                //int id = int.Parse(rdr.GetString(0));  // 0이 뜻하는 것은 컬럼의 순서 0부터 첫번째 컬럼
                //int id = int.Parse(rdr["ID"] as string); //Error

                int EMPNO = int.Parse(rdr["EMPNO"].ToString());
                string ENAME = rdr["ENAME"] as string;
                string JOB = rdr["JOB"] as string;
                DateTime hireDate = rdr.GetDateTime(rdr.GetOrdinal("HIREDATE"));
                string HIREDATE = hireDate.ToString();
                int SAL = int.Parse(rdr["SAL"].ToString());
                int DEPTNO = int.Parse(rdr["DEPTNO"].ToString());
                Console.WriteLine($"{EMPNO} : {ENAME} : {JOB} : {HIREDATE} : {SAL} : {DEPTNO}");
            }

            //리소스 반환
            conn.Close();


        }
    }
}
