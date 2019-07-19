using System;
using System.Threading;

namespace Accounts.Runtime.Model
{
    public class SessionState
    {
        // Thread local variable containing each thread's ID
        private static ThreadLocal<SessionState> sessionState = new ThreadLocal<SessionState>();
        private DateTime? valueDate;
        private DateTime? actionDate;

        public DateTime ValueDate {
            get{
                if (!valueDate.HasValue) {
                    return actionDate.Value;
                }

                return valueDate.Value;
            }

            set => valueDate = value;
        }

        public DateTime ActionDate {
            get
            {
                if (!actionDate.HasValue) {
                    actionDate = DateTime.Now.Date;
                }

                return actionDate.Value;
            }

            set => actionDate = value;
        }

        public static SessionState Current
        {
            get
            {
                if (sessionState.Value == null)
                {
                    sessionState.Value = new SessionState();
                }

                return sessionState.Value;
            }
        }

    };
}
