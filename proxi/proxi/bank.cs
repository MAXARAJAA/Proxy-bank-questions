using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proxi
{
    internal class IBank
    {
        public interface IBankk
        {
            string GetConsultation(string question);
        }

        public class Bank : IBankk
        {
            public string GetConsultation(string question)
            {
                
                return "Банк відповів на ваше питання : " + question;
            }
        }

        public class BankProxy : IBankk
        {
            private readonly IBankk _bank;

            public BankProxy()
            {
                _bank = new Bank();
            }

            public string GetConsultation(string question)
            {
                if (!IsValidQuestion(question))
                {
                    return "Ми не можемо відповісти на це питання ";
                }

                return _bank.GetConsultation(question);
            }

            private bool IsValidQuestion(string question)
            {
                List<string> validQuestions = new List<string>()
                 {
                     "Що таке кредитний рейтинг?",
                     "Як можна відкрити банківський рахунок?",
                     "В чому різниця між дебетовою та кредитною карткою?",
            
                };

                return validQuestions.Contains(question);
            }
        }


    }
}
