using Every_day;
using System;

namespace NotesTREEEEEESH
{
    class Program
    {
        static void Main()
        {
            List<Note> notes = Notes();
            DateTime now = DateTime.Now.Date;
            int position = 1;
            ConsoleKeyInfo key = Console.ReadKey();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введенная дата: " + now);
                foreach (Note item in notes)
                {
                    if (now.Date == item.date.Date)
                    {
                        Console.WriteLine("  " + item.Name);
                    }
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    now = now.AddDays(-1);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    now = now.AddDays(1);
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    AbouteNote(now);
                }
            }
        }
        static void AbouteNote(DateTime now)
        {
            Console.Clear();
            List<Note> notes = Notes();
            foreach (Note item in notes)
            {
                if (item.date == now.Date)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"описание: {item.description}");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("ткните куда-нибудь, чтобы выйти");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        static List<Note> Notes()
        {
            Note note = new Note();
            DateTime dateTime = DateTime.Today;

            note.Name = "сходить ко врачу";
            note.description = "записаться к офтальмологу и на мрт, узнать, где были мои глаза и мозг, когда он мне нравился";
            note.date = dateTime;
            note.position = 1;

            Note note2 = new Note();

            note2.Name = "придумать план действий в случае отчисления";
            note2.description = "подыскать подходящую трассу. поплакать";
            note2.date = dateTime.AddDays(1);
            note2.position = 2;

            Note note3 = new Note();

            note3.Name = "выяснить, кто забрал пятницу";
            note3.description = "послушать новые альбомы";
            note3.date = dateTime.AddDays(+2);
            note3.position = 3;

            Note note4 = new Note();

            note4.Name = "сделать дз";
            note4.description = "поплакать над новым ноутом";
            note4.date = dateTime.AddDays(+3);
            note4.position = 4;

            Note note5 = new Note();

            note5.Name = "подумать о будущем";
            note5.description = "напиться.";
            note5.date = dateTime.AddDays(+4);
            note5.position = 5;

            List<Note> notes = new List<Note>();
            notes.Add(note);
            notes.Add(note2);
            notes.Add(note3);
            notes.Add(note4);
            notes.Add(note5);
            return notes;
        }
    }
}