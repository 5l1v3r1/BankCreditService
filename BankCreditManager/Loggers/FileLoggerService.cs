using BankCrediService.Abstract;
using System;

namespace BankCrediService
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya başarıyla loglandı!");
        }
    }

}
