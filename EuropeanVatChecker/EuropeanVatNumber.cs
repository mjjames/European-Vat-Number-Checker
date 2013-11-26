using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EuropeanVatChecker
{
    public class EuropeanVatNumber
    {
        private EuropeanState _memberState;
        public EuropeanState MemberState
        {
            get { return _memberState; }
            set
            {
                _memberState = value;
                StateInfo = EuropeanStates.FromState(value);
            }
        }
        public EuropeanStateInfo StateInfo { get; private set; }
        public string Number { get; set; }

        public string FormattedNumber
        {
            get
            {
                return string.Format("{0}{1}", StateInfo != null ?  StateInfo.ShortCode : "", Number);
            }
        }

        public bool IsFormatValid()
        {
            if (string.IsNullOrWhiteSpace(Number) || StateInfo == null)
            {
                return false;
            }

            var pattern = StateInfo.ValidationPattern;
            var regEx = new Regex(pattern);
            return regEx.IsMatch(FormattedNumber);
        }

    }
}
