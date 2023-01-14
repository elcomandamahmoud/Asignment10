using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment10.ViewModel
{
    public class MyFunctions
    {
        public string GetGrade(int Grade)
        {
            string Evaluation;
            if (Grade>=0 && Grade<50)
            {
                Evaluation = "للأسف أنت راسب، حظ أوفر في العام القادم";
            }
            else if (Grade>=50 && Grade<=65)
            {
                Evaluation = "مقبول، حاول تحسين مستواك في العام القادم";
            }
            else if (Grade>65 && Grade<=80)
            {
                Evaluation = "جيد، ننصحك بالجتهاد لكي تصل إلى تقدير أعلى في العام القادم";
            }
            else if (Grade>80 && Grade<=90)
            {
                Evaluation = "جيد جدا، أحسنت، لكن ننصحك بالاجتهاد أكثر لتصل إلى تقدير الممتاز في العام القادم";
            }
            else if (Grade>90 && Grade<=100)
            {
                Evaluation = "ممتاز، أحسنت";
            }
            else
            {
                Evaluation="من فضلك أدخل قيمة صحيحة بين 0 وا 100";
            }
            return Evaluation;
        }
    }
}
