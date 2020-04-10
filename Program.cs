using System;
namespace Workers
{
    class Program
    {
        public static void Main()
        {
            int User = DocumentWorker.ChooseUser();
            int Current = UserConfigure(User);
            DocumentWorker Worker = new DocumentWorker();
            if (Current == 1) { Worker = new ProDocumentWorker(); }
            if (Current == 2) { Worker = new ExpertDocumentWorker(); }
            if (Current == 3) { Worker = new DocumentWorker(); }
            Options(Worker);
            System.Console.WriteLine("////////////////////////////////////3");
            IPlayable p = new Player();
            IRecodable i = new Player();
            bool op = false;
            while (op == false)
            {
                System.Console.WriteLine("1.Play");
                System.Console.WriteLine("2.Pause");
                System.Console.WriteLine("3.Stop");
                System.Console.WriteLine("4.Record");
                int num = int.Parse(Console.ReadLine());
                if (num == 1) { p.Play(); }
                if (num == 2) { p.Pause(); }
                if (num == 3) { p.Stop(); }
                if (num == 4) { i.Record(); }
            }
        }
        public static void Options(DocumentWorker Worker)
        {
            bool quit = false;
            while (quit == false)
            {
                System.Console.WriteLine("1.Open Document");
                System.Console.WriteLine("2.Edit Document");
                System.Console.WriteLine("3.Save Document");
                System.Console.WriteLine("4.Quit");
                System.Console.Write("Choose number from list above:");
                int Choise = int.Parse(Console.ReadLine());
                if (Choise == 1) { Worker.OpenDocument(); }
                if (Choise == 2) { Worker.EditDocument(); }
                if (Choise == 3) { Worker.SaveDocument(); }
                if (Choise == 4) { quit = true; }
            }
        }
        public static int UserConfigure(int User)
        {
            int position = 0;
            switch (User)
            {
                case 1:
                    {
                        System.Console.Write("Write your promocode:");
                        string promo = Console.ReadLine();
                        if (ProDocumentWorker.pro == promo)
                        {
                            position = 1;
                            System.Console.WriteLine("Your promocode is correct! So you entered to pro account");

                        }
                        else
                        {
                            System.Console.WriteLine("Your promocode is incorrect! So you entere to free account");
                        }
                    }
                    break;
                case 2:
                    {
                        System.Console.Write("Write your promocode:");
                        string promo = Console.ReadLine();
                        if (ProDocumentWorker.pro == promo)
                        {
                            position = 2;
                            System.Console.WriteLine("Your promocode is correct! So you entered to exp account");

                        }
                        else
                        {
                            System.Console.WriteLine("Your promocode is incorrect! So you entere to free account");
                        }
                    }
                    break;
                case 3:
                    {
                        position = 3;
                        System.Console.WriteLine("You entered to free account");
                    }
                    break;
            }
            return position;
        }
    }
    class DocumentWorker
    {
        public static int ChooseUser()
        {
            System.Console.WriteLine("1.Write promocode for professional");
            System.Console.WriteLine("2.Write promocode for expert");
            System.Console.WriteLine("3.Enter as Free User");
            System.Console.Write("Choose number from list above:");
            int enter = int.Parse(Console.ReadLine());
            return enter;
        }
        public virtual void OpenDocument()
        {
            System.Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            System.Console.WriteLine("Редактирование документа доступно в версии про");
        }
        public virtual void SaveDocument()
        {
            System.Console.WriteLine("Сохранение документа доступно в версии про");
        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public static string pro { get { return "pro"; } }
        public override void EditDocument()
        {
            System.Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            System.Console.WriteLine("Документ сохранён в старом формате,сохранение в остальных форматах доступно в версии про");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public string exp { get { return "exp"; } }
        public override void SaveDocument()
        {
            System.Console.WriteLine("Документ сохранён в новом формате");
        }
    }
    interface IPlayable
    {
        void Play()
        {
            System.Console.WriteLine("Play");
        }
        void Pause()
        {
            System.Console.WriteLine("Pause");
        }
        void Stop()
        {
            System.Console.WriteLine("Stop");
        }
    }
    interface IRecodable
    {
        void Record()
        {
            System.Console.WriteLine("Record");
        }
        void Pause()
        {
            System.Console.WriteLine("Pause");
        }
        void Stop()
        {
            System.Console.WriteLine("Stop");
        }
    }
    class Player : IPlayable, IRecodable
    {

    }
}