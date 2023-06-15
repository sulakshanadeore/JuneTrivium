using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
    public class Books
    {
        private int? _bookid;
        //private Nullable<int> _bookid;

        public int? BookID
        {
            get {
                //if (this._bookid != null)


                return this._bookid;
                
                

            }
            set 
            {
                if ( value!=0 && value>0 ) 
                {
                    _bookid = value;
                }
                
            }
        }

        private float _price;

        public float BookPrice
        {
            get { return _price; }
            set { _price = value; }
        }

        //Create a property to display the bookname and accept the bookname
        private string _bookname;
        public string BookName 
        {
            //getter block----display/return the value
            get 
            {
            return _bookname;
            }
            //setter block--- assign/accept the value
            set 
            {
                if(value.Length > 0)
                {
                    _bookname = value;

                }
                else
                {
                    Console.WriteLine("Book name must be atleast 1 character");
                }
                
            }
        
        
        }
    }
}
