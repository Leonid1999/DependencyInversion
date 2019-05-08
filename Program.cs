using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Messege mess = new Messege(new VideoMessege());
            mess.PrintType();
            mess.Type = new SMSMessege();
            mess.PrintType();
            mess.Type = new AudioMessege();
            mess.PrintType();
            Console.ReadLine();
        }

        interface IType
        {
            void PrintType(string text);

        }

        class Messege
        {
            public string Text { get; set; }
            public IType Type { get; set; }
            public Messege(IType type)
            {
                this.Type = type;
            }

            public void PrintType()
            {
                Type.PrintType(Text);
            }
        }
        //type
        class SMSMessege : IType
        {
            public void PrintType(string text)
            {
                Console.WriteLine("This is SMS");
            }
        }

        class VideoMessege : IType
        {
            public void PrintType(string text)
            {
                Console.WriteLine("This is Video Messege");
            }
        }
        class AudioMessege : IType
        {
            public void PrintType(string text)
            {
                Console.WriteLine("This is Audio Messege");
            }
        }
    }
    }
        //format
        