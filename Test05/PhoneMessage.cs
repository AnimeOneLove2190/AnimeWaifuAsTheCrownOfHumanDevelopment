using System;
using System.Collections.Generic;
using System.Text;

namespace Test05Feature534
{
    class PhoneMessage : Message
    {
        public int SenderNumber { get; set; }
        public int RecipientNumber { get; set; }
        public override string Send()
        {
            return $"SMS №{Id} было отправлено с номера {SenderNumber} для номера {RecipientNumber}";
        }
    }
}
