using OWBAlgorithm.Services.EvaluationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWBAlgorithm.Services.ProfileServices
{
    public class ProfileManager : IProfileService
    {
        private readonly IEvaluationService _evaulationService;

        public ProfileManager(IEvaluationService evaulationService)
        {
            _evaulationService = evaulationService;
        }

        public Profile GetProfile()
        {
            var evo = _evaulationService.SelecetEvaluation();

            var profileMappings = new Dictionary<List<Evaluation>, Profile>(new EvaluationListComparer())
                {
                    { new List<Evaluation> { Evaluation.HAK_P, Evaluation.AKT_P, Evaluation.HİÇ_P, Evaluation.UM_M }, Profile.Çaresiz },
                    { new List<Evaluation> { Evaluation.HAK_P, Evaluation.AKT_P, Evaluation.HİÇ_M, Evaluation.UM_P }, Profile.Yılmaz },
                    { new List<Evaluation> { Evaluation.HAK_P, Evaluation.AKT_M, Evaluation.HİÇ_P, Evaluation.UM_P }, Profile.Umutlu },
                    { new List<Evaluation> { Evaluation.HAK_P, Evaluation.AKT_M, Evaluation.HİÇ_M, Evaluation.UM_P }, Profile.Savaşcı },
                    { new List<Evaluation> { Evaluation.HAK_P, Evaluation.AKT_M, Evaluation.HİÇ_M, Evaluation.UM_M }, Profile.Zorlanan },
                    { new List<Evaluation> { Evaluation.HAK_M, Evaluation.AKT_M, Evaluation.HİÇ_M, Evaluation.UM_M }, Profile.Motivasyonsuz },
                    { new List<Evaluation> { Evaluation.HAK_P, Evaluation.AKT_P, Evaluation.HİÇ_M, Evaluation.UM_M }, Profile.Amaçsız },
                    { new List<Evaluation> { Evaluation.HAK_M, Evaluation.AKT_P, Evaluation.HİÇ_P, Evaluation.UM_P }, Profile.Eşikte },
                    { new List<Evaluation> { Evaluation.HAK_M, Evaluation.AKT_P, Evaluation.HİÇ_M, Evaluation.UM_P }, Profile.Odaklanmış },
                    { new List<Evaluation> { Evaluation.HAK_M, Evaluation.AKT_P, Evaluation.HİÇ_M, Evaluation.UM_M }, Profile.Umutsuz },
                    { new List<Evaluation> { Evaluation.HAK_M, Evaluation.AKT_M, Evaluation.HİÇ_P, Evaluation.UM_M }, Profile.Tükenmiş },
                    { new List<Evaluation> { Evaluation.HAK_P, Evaluation.AKT_M, Evaluation.HİÇ_P, Evaluation.UM_M }, Profile.Kaybolmuş },
                    { new List<Evaluation> { Evaluation.HAK_M, Evaluation.AKT_M, Evaluation.HİÇ_M, Evaluation.UM_P }, Profile.Umutlu2 },
                    { new List<Evaluation> { Evaluation.HAK_M, Evaluation.AKT_M, Evaluation.HİÇ_P, Evaluation.UM_P }, Profile.Sorgulayan }
                };
            foreach (var mapping in profileMappings)
            {
                if (evo.SequenceEqual(mapping.Key))
                {
                    return mapping.Value;
                }
            }
            return Profile.Boooooş;
        }
    }
    class EvaluationListComparer : IEqualityComparer<List<Evaluation>>
    {
        public bool Equals(List<Evaluation> x, List<Evaluation> y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(List<Evaluation> obj)
        {
            int hash = 17;
            foreach (var eval in obj)
            {
                hash = hash * 31 + eval.GetHashCode();
            }
            return hash;
        }
    }
}

