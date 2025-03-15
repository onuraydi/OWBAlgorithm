using OWBAlgorithm.Services.AnswerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWBAlgorithm.Services.EvaluationServices
{
    public class EvaluationManager : IEvaluationService
    {
        private readonly IAnswerService _answerService;

        public EvaluationManager(IAnswerService answerService)
        {
            _answerService = answerService;
        }


        List<Evaluation> IEvaluationService.SelecetEvaluation()
        {
            List<Evaluation> evaluationList = new List<Evaluation>();

            var answers = _answerService.GetAllAnswer();

            int groupCount = 0;
            int groupIndex = 0;

            for (int i = 0; i < 20; i++)
            {
                if (answers[i] == true)
                {
                    groupCount++;
                }

                if ((i + 1) % 5 == 0)
                {
                    switch (groupIndex)
                    {
                        case 0:
                            evaluationList.Add(groupCount >= 3 ? Evaluation.HAK_P : Evaluation.HAK_M);
                            break;
                        case 1:
                            evaluationList.Add(groupCount >= 3 ? Evaluation.AKT_P : Evaluation.AKT_M);
                            break;
                        case 2:
                            evaluationList.Add(groupCount >= 3 ? Evaluation.HİÇ_P : Evaluation.HİÇ_M);
                            break;
                        case 3:
                            evaluationList.Add(groupCount >= 3 ? Evaluation.UM_P : Evaluation.UM_M);
                            break;
                    }
                    groupCount = 0;
                    groupIndex++;
                }
            }
            return evaluationList;
        }
    }
}
