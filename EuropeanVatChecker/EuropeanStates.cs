using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanVatChecker
{
    public class EuropeanStates
    {
        private static Dictionary<EuropeanState, EuropeanStateInfo> _statesByState;
        private static Dictionary<string, EuropeanStateInfo> _statesByShortCode;
        static EuropeanStates()
        {
            var states = new List<EuropeanStateInfo>(new[]{            
                            new EuropeanStateInfo { ShortCode = "AT", ValidationPattern = "^ATU[A-Z0-9]{8,8}$", State = EuropeanState.Austria },
                            new EuropeanStateInfo { ShortCode = "BE", ValidationPattern = "^BE[0-9]{9,9}$", State = EuropeanState.Belgium },
                            new EuropeanStateInfo { ShortCode = "BG", ValidationPattern = "^BG[0-9]{9,10}$", State = EuropeanState.Bulgaria },
                            new EuropeanStateInfo { ShortCode = "CY", ValidationPattern = "^CY[0-9]{9,9}$", State = EuropeanState.Cyprus },
                            new EuropeanStateInfo { ShortCode = "CZ", ValidationPattern = "^CZ[0-9]{8,10}$", State = EuropeanState.CzechRepublic},
                            new EuropeanStateInfo { ShortCode = "DE", ValidationPattern = "^DE[0-9]{9,9}$", State = EuropeanState.Germany },
                            new EuropeanStateInfo { ShortCode = "DK", ValidationPattern = "^DK[0-9]{8,8}$", State = EuropeanState.Denmark },
                            new EuropeanStateInfo { ShortCode = "EE", ValidationPattern = "^EE[0-9]{9,9}$", State = EuropeanState.Estonia },
                            new EuropeanStateInfo { ShortCode = "EL", ValidationPattern = "^EL[0-9]{9,9}$", State = EuropeanState.Greece },
                            new EuropeanStateInfo { ShortCode = "ES", ValidationPattern = "^ES[A-Z0-9]{1,1}[0-9]{7,7}[A-Z0-9]{1,1}$", State = EuropeanState.Spain },
                            new EuropeanStateInfo { ShortCode = "FI", ValidationPattern = "^FI[0-9]{8,8}$", State = EuropeanState.Finland },
                            new EuropeanStateInfo { ShortCode = "FR", ValidationPattern = "^FR[A-Z0-9]{2,2}[0-9]{9,9}$", State = EuropeanState.France },
                            new EuropeanStateInfo { ShortCode = "GB", ValidationPattern = "^GB[0-9]{9,9}$|^GB[0-9]{12,12}$|^GBGD[0-9]{3,3}$", State = EuropeanState.UnitedKingdom },
                            new EuropeanStateInfo { ShortCode = "HU", ValidationPattern = "^HU[0-9]{8,8}$", State = EuropeanState.Hungary },
                            new EuropeanStateInfo { ShortCode = "HR", ValidationPattern = "^HR[0-9]{11,11}$", State = EuropeanState.Croatia },
                            new EuropeanStateInfo { ShortCode = "IE", ValidationPattern = "^IE[A-Z0-9]{8,8}$", State = EuropeanState.Ireland },
                            new EuropeanStateInfo { ShortCode = "IT", ValidationPattern = "^IT[0-9]{11,11}$", State = EuropeanState.Italy },
                            new EuropeanStateInfo { ShortCode = "LT", ValidationPattern = "^LT[0-9]{9,9}$|^LT[0-9]{12,12}$", State = EuropeanState.Lithuania },
                            new EuropeanStateInfo { ShortCode = "LU", ValidationPattern = "^LU[0-9]{8,8}$", State = EuropeanState.Luxembourg },
                            new EuropeanStateInfo { ShortCode = "LV", ValidationPattern = "^LV[0-9]{11,11}$", State = EuropeanState.Latvia },
                            new EuropeanStateInfo { ShortCode = "MT", ValidationPattern = "^MT[0-9]{8,8}$", State = EuropeanState.Malta },
                            new EuropeanStateInfo { ShortCode = "NL", ValidationPattern = "^NL[A-Z0-9]{9,9}B[A-Z0-9]{2,2}$", State = EuropeanState.TheNetherlands },
                            new EuropeanStateInfo { ShortCode = "PL", ValidationPattern = "^PL[0-9]{10,10}$", State = EuropeanState.Poland },
                            new EuropeanStateInfo { ShortCode = "PT", ValidationPattern = "^PT[0-9]{9,9}$", State = EuropeanState.Portugal },
                            new EuropeanStateInfo { ShortCode = "RO", ValidationPattern = "^RO[0-9]{2,10}$", State = EuropeanState.Romania },
                            new EuropeanStateInfo { ShortCode = "SE", ValidationPattern = "^SE[0-9]{12,12}$", State = EuropeanState.Sweden },
                            new EuropeanStateInfo { ShortCode = "SI", ValidationPattern = "^SI[0-9]{8,8}$", State = EuropeanState.Slovenia },
                            new EuropeanStateInfo { ShortCode = "SK", ValidationPattern = "^SK[0-9]{10,10}$", State = EuropeanState.Slovakia }
            });
            _statesByShortCode = states.ToDictionary(s => s.ShortCode, s => s);
            _statesByState = states.ToDictionary(s => s.State, s => s);
        }

        public static EuropeanStateInfo FromShortCode(string shortCode)
        {
            return _statesByShortCode[shortCode];
        }

        public static EuropeanStateInfo FromState(EuropeanState state)
        {
            return _statesByState[state];
        }
    }
}
