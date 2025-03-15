using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWBAlgorithm.Services.AnswerServices
{
    public class AnswerManager : IAnswerService
    {
        List<bool> answerList = new List<bool>();
        public void AddAnswer(bool answer)
        {
            answerList.Add(answer);
        }
        public void AddAnswer(List<bool> answers)
        {
            answerList.AddRange(answers);
        }

        public List<bool> GetAllAnswer()
        {
            if(answerList.Count() == 20)
            {
                return answerList;
            }
            else
            {
                throw new Exception("Must have 20 answers");
            }
        }
    }
}
