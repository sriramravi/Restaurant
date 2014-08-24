using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Web;
using System.Text;
using System.Collections;

namespace SqlHelperDemo
{
 
    public static class sqlProductProvider
    {    
        
        public static string SqlConStr
        {
            get
            {
                return ConfigurationManager.AppSettings["SqlConnStr"];
                //return "server=SURESH-063253FF;Database=RES_2014;Integrated Security=True;";
            }
        }

    //    public static void ShowMsgBox(string Strmsg);
    //{
        
    //}
       
        public static string LoginStatus(string UserId, string PassWord)
        {
            DataTable dtbLogin = new DataTable();
            DataRow drwLogin;

            object obj;
            try
            {
                dtbLogin.Columns.Add("UserName", typeof(string));
                dtbLogin.Columns.Add("PassWord", typeof(string));
                drwLogin = dtbLogin.NewRow();
                drwLogin["UserName"] = UserId;
                drwLogin["PassWord"] = PassWord;
                dtbLogin.Rows.Add(drwLogin);
                obj = SqlHelper.ExecuteScalarTypedParams(SqlConStr, "Pro_LoginGet", drwLogin);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return obj.ToString();
        }

        public static object SetData(DataRow dr, string StrPro)
        {
            try
            {
                return SqlHelper.ExecuteNonQueryTypedParams(SqlConStr, StrPro, dr);

            }
            catch (Exception ex)
            {
                return ex;
            }

        }
      
        public static DataSet Getdata(string strQry)
        {
            SqlCommand cmd = new SqlCommand();           
            cmd.CommandText = strQry;
            return SqlHelper.ExecuteDataset(SqlConStr, cmd.CommandType, strQry);
        }

        public static string StrReplace(string Str)
        {
            Str = Str.Replace("'", "''");
            return Str;
        }

        public static int GetSingleVal(string strQry)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strQry;
            return Convert.ToInt16(SqlHelper.ExecuteScalar(SqlConStr, cmd.CommandType, cmd.CommandText));
            

        }
        public static int GetSingleVal(SqlTransaction SqlTrans,  string strQry)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strQry;
            return Convert.ToInt16(SqlHelper.ExecuteScalar( SqlTrans, cmd.CommandType, cmd.CommandText));


        }

        public static int GetSingleVal(string strPro,DataRow dr)
        {
            return Convert.ToInt16(SqlHelper.ExecuteScalarTypedParams(SqlConStr, strPro, dr));

        }
       
        public static int GetSingleVal(SqlTransaction sqlTran, SqlCommand cmd, string strQry)
        {
            return Convert.ToInt16(SqlHelper.ExecuteScalar(sqlTran, cmd.CommandType, strQry));
        }
        public static String GetSingleStr(DataRow dr, string StrPro)
        {
         
            return Convert.ToString(SqlHelper.ExecuteScalarTypedParams(SqlConStr,StrPro,dr));
        }
        public static String GetSingleStr(SqlTransaction sqlTran, DataRow dr, string StrPro)
        {

            return Convert.ToString(SqlHelper.ExecuteScalarTypedParams(sqlTran, StrPro, dr));
        }
        public static String GetSingleStr(string strQry)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strQry;
            return Convert.ToString(SqlHelper.ExecuteScalar(SqlConStr, cmd.CommandType, cmd.CommandText));
        }

       
      
     
     
      

      
   
        //public static void GridBind( Gv, string StrQry)
        //{
          
        //    DataSet ds = new DataSet();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = StrQry;
        //    ds = SqlHelper.ExecuteDataset(SqlConStr, cmd.CommandType, cmd.CommandText);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        Gv.DataSource = ds;
        //        Gv.DataBind();
        //    }
        //    else
        //    {
        //        Gv.DataSource = null;
        //        Gv.DataBind();     
        //    }
          
     
        //}
        public static string RemoveSpecialChars(string str)
        {
            string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "-", "_", "(", ")", ":", "|", "[", "]" };
            for (int i = 0; i < chars.Length; i++)
            {
                if (str.Contains(chars[i]))
                {
                    str = str.Replace(chars[i], "");
                }
            }
            return str;
        }
     

        public  static string strdate(string arg)
        {
            string[] strarray;
            
            if (arg.Contains("/"))
            {
                strarray = arg.Split('/');
            }
            else
            {
                strarray = arg.Split('-');
            }
            //string[] strarray = argument.Split('/');
            string[] strmonth = { "", "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
            if (strarray.Length == 3)
            {

                //argument = strarray[1] + '/' + strarray[0] + '/' + strarray[2];
                arg = strarray[0] + '/' + strmonth[Convert.ToInt16(strarray[1])] + '/' + strarray[2];

            }
            else
            {

                arg = "INVALID";

            }

            return arg;
        }

        public static string StrYYYYMMDD(string DDMMYYYY)
        {
            //string[] str = DDMMYYYY.Split('/');
            string[] str;
            if (DDMMYYYY.Contains("/"))
            {
                str = DDMMYYYY.Split('/');
            }
            else
            {
                str = DDMMYYYY.Split('-');
            }

            if (str.Length == 3)
            {
                DDMMYYYY = str[2] + "/" + str[0] + "/" + str[1];
            }
            else
            {
                DDMMYYYY = "Invalid";
            }
            return DDMMYYYY;
        }
       
     
        
        
        public static String GetSeparateDate(String datetime)
        {
            String[] arr = new String[2];
            arr = datetime.Split(' ');
            String finaldate = arr[0];
            return finaldate;

        }
        
        public static object cmd(string StrQry)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(SqlConStr, CommandType.Text, StrQry);
            }
            catch (Exception ex)
            {
                return ex;
            }

        }
        public static string  cmdinsert(string StrQry,string DataRow)
        {           
               // int a=0;
               //// SqlHelper.ExecuteNonQuery(SqlConStr, CommandType.Text, StrQry);
               // SqlConnection con=new SqlConnection();
               // con.Open();
               // SqlCommand com=new SqlCommand(StrQry,con);
               // a= com.ExecuteNonQuery();
               // return a;
            DataTable dtb = new DataTable();
            DataRow drw;
            object obj;
            try
            {
                dtb.Columns.Add("msg", typeof(string));
                drw = dtb.NewRow();
                drw["msg"] = DataRow;
                dtb.Rows.Add(drw);
                obj = SqlHelper.ExecuteScalarTypedParams(SqlConStr, StrQry, drw);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return obj.ToString();

        }

    }
}