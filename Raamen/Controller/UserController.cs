using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using Raamen.Handler;

namespace Raamen.Controller
{
    public class UserController
    {
        public static String CheckUsername(String username)
        {
            String message = "";
            if (username.Equals(""))
            {
                message = "Please Enter Username!";
            } else if (username.Length < 5 || username.Length > 15)
            {
                message = "Username must be between 5 and 15 characters!";
            }

            foreach (char x in username)
            {
                if (!Char.IsLetter(x) && !Char.IsWhiteSpace(x))
                {
                    message = "Username must include alphabets and spaces only";
                }
            }

            return message;
        }

        public static String CheckEmailRegister(String email)
        {
            String message = "";
            if (email.Equals(""))
            {
                message = "Please Enter Email!";
            }
            else
            {
                int a = email.Length;

                string text = email;
                char[] arr = text.ToCharArray();



                if (a < 5)
                {
                    message = "Emails Must End With .com";
                }
                else
                {
                    char d = arr[a - 1];
                    char f = arr[a - 2];
                    char g = arr[a - 3];
                    char h = arr[a - 4];

                    string dstring = d.ToString();
                    string fstring = f.ToString();
                    string gstring = g.ToString();
                    string hstring = h.ToString();
                    if (dstring == "m")
                    {
                        message = "";
                    }
                    if (fstring == "o")
                    {
                        message = "";
                    }
                    if (gstring == "c")
                    {
                        message = "";
                    }
                    if (hstring == ".")
                    {
                        message = "";
                    }
                    else
                    {
                        message = "Emails Must End With .com";
                    }
                }
            }
            return message;
        }

        public static String CheckGenderRegister(String gender)
        {
            String message = "";
            if (gender.Equals("---Select Below---"))
            {
                message = "Please Select Your Gender!";
            }
            return message;
        }
        public static String CheckPassword(String password)
        {
            String message = "";
            if (password.Equals(""))
            {
                message = "Please Enter Password!";
            }

            return message;
        }

        public static String CheckConfirmPassword(String password,String cpassword)
        {

            String message = "";
            if (cpassword.Equals(""))
            {
                message = "Please Confirm Password!";
            }else if (cpassword != password)
            {
                message = "Password not matched";
            }

            return message;
        }

        public static String Login(String username, String password)
        {
            String message = CheckUsername(username);
            if (message.Equals(""))
            {
                message = CheckPassword(password);
            }
            if (message.Equals(""))
            {
                message = UserHandler.CheckUserLogin(username, password);
            }

            return message;
        }
        public static String Register(String username, String email, String gender, String password, String cpassword)
        {
            String message = CheckUsername(username);
            if (message.Equals(""))
            {
                message = CheckEmailRegister(email);
            }
            if (message.Equals(""))
            {
                message = CheckGenderRegister(gender);
            }
            if (message.Equals(""))
            {
                message = CheckPassword(password);
            }
            if (message.Equals(""))
            {
                message = CheckConfirmPassword(password, cpassword);
            }

            if (message.Equals(""))
            {
                message = UserHandler.CheckUserRegister(username);
            }

            return message;
        }
    }
}