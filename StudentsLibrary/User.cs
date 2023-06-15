using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
    public class User
    {

		private int _userid;
		//read-write 
		public int userid
		{
			get { return _userid; }
			set { _userid = value; }
		}

		private string _pass;

		//write only
		public string  Password
		{
			//Write only property
			set 
			{
				if (value=="abc@123")
				{
					_pass = value;
                    Console.WriteLine("User validated");
                }
				else
				{

                    Console.WriteLine("Incorrect password");
                }
			
			}
		}


		//readonly
		private string _showpwd;
		public string ShowPwd
		{
			get 
			{
				_showpwd = "abc@123";
				return _showpwd;
			
			}
		}




	}
}
