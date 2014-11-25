// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class Reject : Message
        {
            public const string MsgType = "3";

            public Reject() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("3"));
            }

            public Reject(
                    QuickFix.Fields.RefSeqNum aRefSeqNum,
                    QuickFix.Fields.Text aText,
                    QuickFix.Fields.RefTagID aRefTagID,
                    QuickFix.Fields.RefMsgType aRefMsgType,
                    QuickFix.Fields.SessionRejectReason aSessionRejectReason
                ) : this()
            {
                this.RefSeqNum = aRefSeqNum;
                this.Text = aText;
                this.RefTagID = aRefTagID;
                this.RefMsgType = aRefMsgType;
                this.SessionRejectReason = aSessionRejectReason;
            }

            public QuickFix.Fields.RefSeqNum RefSeqNum
            { 
                get 
                {
                    QuickFix.Fields.RefSeqNum val = new QuickFix.Fields.RefSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefSeqNum val) 
            { 
                this.RefSeqNum = val;
            }
            
            public QuickFix.Fields.RefSeqNum Get(QuickFix.Fields.RefSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefSeqNum val) 
            { 
                return IsSetRefSeqNum();
            }
            
            public bool IsSetRefSeqNum() 
            { 
                return IsSetField(Tags.RefSeqNum);
            }
            public QuickFix.Fields.Text Text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Text val) 
            { 
                this.Text = val;
            }
            
            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(Tags.Text);
            }
            public QuickFix.Fields.RefTagID RefTagID
            { 
                get 
                {
                    QuickFix.Fields.RefTagID val = new QuickFix.Fields.RefTagID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefTagID val) 
            { 
                this.RefTagID = val;
            }
            
            public QuickFix.Fields.RefTagID Get(QuickFix.Fields.RefTagID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefTagID val) 
            { 
                return IsSetRefTagID();
            }
            
            public bool IsSetRefTagID() 
            { 
                return IsSetField(Tags.RefTagID);
            }
            public QuickFix.Fields.RefMsgType RefMsgType
            { 
                get 
                {
                    QuickFix.Fields.RefMsgType val = new QuickFix.Fields.RefMsgType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefMsgType val) 
            { 
                this.RefMsgType = val;
            }
            
            public QuickFix.Fields.RefMsgType Get(QuickFix.Fields.RefMsgType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefMsgType val) 
            { 
                return IsSetRefMsgType();
            }
            
            public bool IsSetRefMsgType() 
            { 
                return IsSetField(Tags.RefMsgType);
            }
            public QuickFix.Fields.SessionRejectReason SessionRejectReason
            { 
                get 
                {
                    QuickFix.Fields.SessionRejectReason val = new QuickFix.Fields.SessionRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SessionRejectReason val) 
            { 
                this.SessionRejectReason = val;
            }
            
            public QuickFix.Fields.SessionRejectReason Get(QuickFix.Fields.SessionRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SessionRejectReason val) 
            { 
                return IsSetSessionRejectReason();
            }
            
            public bool IsSetSessionRejectReason() 
            { 
                return IsSetField(Tags.SessionRejectReason);
            }

        }
    }
}
