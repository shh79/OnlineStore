using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Text.RegularExpressions;

namespace OnlineStoreWPF
{
    static class Extention
    {
        static public char[] passchar = {'0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','g','h','i','j' ,'k','l','m','n','o','p',
                        'q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','C','L','M','N','O','P',
                        'Q','R','S','T','U','V','X','Y','Z','!','?',' ','*','-','+','$','@','#','%','&'};

        static public string path = Directory.GetCurrentDirectory();

        static public bool Melicode(this string inputcode)
        {
            decimal[] stack = { 0000000000, 1111111111, 2222222222, 3333333333, 4444444444, 5555555555, 6666666666, 7777777777, 8888888888, 9999999999 };

            if (inputcode.Length == 10)
            {
                decimal temp = decimal.Parse(inputcode);

                for(int i = 0; i < stack.Length; ++i)
                {
                    if (stack[i] == temp)
                    {
                        return false;
                    }
                }
                

                return calculate(temp);
            }
            else
            {
                return false;
            }
        }
        static private bool calculate(decimal input)
        {

            int A = (int)(input % 10);

            int temp = (int)(input / 10);


            int B = controlnum(temp);

            int C = B % 11;


            if (C >= 2)
            {
                int temp2 = 11 - C;

                if (temp2 == A)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }
            else
            {
                if (C == A)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }


        }
        static private int controlnum(int a)
        {
            int output = 0;
            for (int i = 2; i < 11; ++i)
            {
                output += (a % 10) * i;

                a /= 10;
            }

            return output;
        }

        static public bool STUCode(this int input)
        {
            
            if (input > 9999999 && input<100000000)
            {
                input /= 10000000;

                if (input == 9)
                {
                    return true;
                }

                return false;
            }
            else
            {
                return false;
            }
        }


        static public bool isValidEmail(this string inputEmail)
        {

            // This Pattern is use to verify the email 
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(inputEmail))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        static public string Code(this string pass)
        {
            Random r = new Random();

            int key = r.Next(10, 75);

            char[] seperated = pass.ToCharArray();

            for(int i = 0; i < seperated.Length; ++i)
            {
                for(int j = 0; j < passchar.Length; ++j)
                {
                    if (seperated[i] == passchar[j])
                    {
                        seperated[i] = passchar[limmitarray(j + key)];
                        break;
                    }
                }
            }

            string output = new string(seperated);

            output += key.ToString();
            
            return output;
        }

        static public string DeCode(this string pass)
        {
            string key = pass.Remove(0, pass.Length - 2);
            pass = pass.Remove(pass.Length - 2);

            int intkey = int.Parse(key);

            try
            {
                char[] seperated = pass.ToCharArray();

                for (int i = 0; i < seperated.Length; ++i)
                {
                    for (int j = 0; j < passchar.Length; ++j)
                    {
                        if (seperated[i] == passchar[j])
                        {
                            seperated[i] = passchar[limmitarray(j - intkey)];
                            break;
                        }
                    }
                }

                string output = new string(seperated);

                return output;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "NULL";
            }
        }

        static private int limmitarray(int input)
        {
            if (input >= passchar.Length)
            {
                input -= passchar.Length;
            }
            if (input < 0)
            {
                input += passchar.Length;
            }

            return input;
        }


    }
}
