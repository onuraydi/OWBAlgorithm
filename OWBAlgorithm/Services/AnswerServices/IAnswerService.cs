using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWBAlgorithm.Services.AnswerServices
{
    public interface IAnswerService
    {
        void AddAnswer(bool answer);
        List<bool> GetAllAnswer();
    }
}
