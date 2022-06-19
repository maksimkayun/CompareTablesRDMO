using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using UIFormRDMO.Data.Models;
using UIFormRDMO.Enums;
using UIFormRDMO.WorkingElements;

namespace UIFormRDMO
{
    public class Menu
    {
        internal static PersonsContext _context = new PersonsContext();

        public static int SelectOption(bool skipMenu = false)
        {
            int v = -1;
            StringBuilder sb = new StringBuilder();

            if (!skipMenu)
            {
                sb.AppendLine("0.ВЫХОД");
                sb.AppendLine("1.Указать путь до файла с данными");
                sb.AppendLine("2.Показать базу РДМО");
                sb.AppendLine("3.Показать базу ШТАТ");
                sb.AppendLine("4.Заполнить данные");
                sb.AppendLine("5.Очистить ВСЕ базы");
                sb.AppendLine("6.Начать процедуру сравнения");
            }

            Console.Write(sb + "Введите число-вариант >");
            try
            {
                v = int.Parse(Console.ReadLine()!);
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так! Попробуйте ещё раз)");
                v = SelectOption(true);
            }

            return v;
        }

        private static string? _defaultPath = $"C:/Users/{Environment.UserName}/Desktop/data.txt";
        private static string? _path;

        public static string? Path
        {
            get
            {
                if (_path is null or "")
                {
                    return _defaultPath;
                }

                return _path;
            }
            set
            {
                if (value is null or "")
                {
                    _path = _defaultPath;
                }
                else
                {
                    _path = value;
                }
            }
        }

        public static string Start(string[] variants)
        {
            BaseHelper helper = new BaseHelper(_context);

            switch (int.Parse(variants[0]))
            {
                case 0:
                {
                    break;
                }
                case 1:
                {
                    Console.WriteLine(
                        "Введите полный путь до файла с названием и его раширением, пример: C:/System/file.txt");
                    Console.WriteLine(
                        "!!!Напоминание - в файле сперва идёт список от МИ, потом == и уже после - штатка!!!");
                    Console.Write($"Текущий путь до файла: {Path} \nНовый путь(введите 0, чтобы отменить изменения)>");
                    //string input = Console.ReadLine();
                    // if (input.Equals("0"))
                    // {
                    //     break;
                    // }
                    
                    Path = variants[1];
                    return "ok";
                }
                case 2:
                {
                    // вывод РДМО
                    var data = new OutputInformationHelper(_context).GetAllDatabaseByTable(Table.PersonsList);
                    Console.WriteLine(data);
                    break;
                }
                case 3:
                {
                    // вывод ШТАТ
                    var data = new OutputInformationHelper(_context).GetAllDatabaseByTable(Table.PersonsDB);
                    Console.WriteLine(data);
                    break;
                }
                case 4:
                {
                    // Заполнение данных
                    Debug.Assert(Path != null, nameof(Path) + " != null");
                    try
                    {
                        StreamReader reader = new StreamReader(Path);
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append(reader.ReadToEnd());

                        stringBuilder.Replace("\r", "");

                        helper.InjectInDB(Table.PersonsList,
                            stringBuilder.ToString().Split(Convert.ToChar("\n==\n"))[0]
                                .Split('\n').ToList());
                        helper.InjectInDB(Table.PersonsDB,
                            stringBuilder.ToString().Split(Convert.ToChar("\n==\n"))[1]
                                .Split('\n').ToList());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Что-то пошло не так! {e.Message}\n{e.StackTrace}");
                        return $"При заполнении данных что-то пошло не так! Повторите попытку!";
                    }

                    return "ok";
                }
                case 5:
                {
                    // Очистить списки
                    helper.ClearDB();
                    Console.WriteLine("Вся база очищена");
                    break;
                }
                case 6:
                {
                    // Процедура сравнения
                    try
                    {
                        Worker.Compare(_context);
                        Worker.PrepareResultTable();
                        helper.WriteToFile("res", Path);
                    }
                    catch (Exception e)
                    {
                        return $"При сравнении что-то пошло не так! Проверьте путь и повторите попытку!";
                    }
                    break;
                }
                default:
                {
                    Console.WriteLine("Для выхода введите 0");
                    break;
                }
            }

            return "ok";
        }
    }
}