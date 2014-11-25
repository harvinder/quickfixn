// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX42
    {
        public class MessageFactory : IMessageFactory
        {
            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX42.Heartbeat.MsgType: return new QuickFix.FIX42.Heartbeat();
                    case QuickFix.FIX42.Logon.MsgType: return new QuickFix.FIX42.Logon();
                    case QuickFix.FIX42.TestRequest.MsgType: return new QuickFix.FIX42.TestRequest();
                    case QuickFix.FIX42.ResendRequest.MsgType: return new QuickFix.FIX42.ResendRequest();
                    case QuickFix.FIX42.Reject.MsgType: return new QuickFix.FIX42.Reject();
                    case QuickFix.FIX42.SequenceReset.MsgType: return new QuickFix.FIX42.SequenceReset();
                    case QuickFix.FIX42.Logout.MsgType: return new QuickFix.FIX42.Logout();
                    case QuickFix.FIX42.MarketDataRequest.MsgType: return new QuickFix.FIX42.MarketDataRequest();
                    case QuickFix.FIX42.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX42.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX42.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX42.MarketDataIncrementalRefresh();
                    case QuickFix.FIX42.MarketDataRequestReject.MsgType: return new QuickFix.FIX42.MarketDataRequestReject();
                    case QuickFix.FIX42.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX42.SecurityDefinitionRequest();
                    case QuickFix.FIX42.SecurityDefinition.MsgType: return new QuickFix.FIX42.SecurityDefinition();
                    case QuickFix.FIX42.SecurityStatusRequest.MsgType: return new QuickFix.FIX42.SecurityStatusRequest();
                    case QuickFix.FIX42.SecurityStatus.MsgType: return new QuickFix.FIX42.SecurityStatus();
                    case QuickFix.FIX42.NewOrderSingle.MsgType: return new QuickFix.FIX42.NewOrderSingle();
                    case QuickFix.FIX42.ExecutionReport.MsgType: return new QuickFix.FIX42.ExecutionReport();
                    case QuickFix.FIX42.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX42.OrderCancelReplaceRequest();
                    case QuickFix.FIX42.OrderCancelRequest.MsgType: return new QuickFix.FIX42.OrderCancelRequest();
                    case QuickFix.FIX42.OrderCancelReject.MsgType: return new QuickFix.FIX42.OrderCancelReject();
                    case QuickFix.FIX42.OrderStatusRequest.MsgType: return new QuickFix.FIX42.OrderStatusRequest();
                    case QuickFix.FIX42.BusinessMessageReject.MsgType: return new QuickFix.FIX42.BusinessMessageReject();
                    case QuickFix.FIX42.PositionReport.MsgType: return new QuickFix.FIX42.PositionReport();
                    case QuickFix.FIX42.RequestForPosition.MsgType: return new QuickFix.FIX42.RequestForPosition();
                    case QuickFix.FIX42.GatewayStatusRequest.MsgType: return new QuickFix.FIX42.GatewayStatusRequest();
                    case QuickFix.FIX42.GatewayStatus.MsgType: return new QuickFix.FIX42.GatewayStatus();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX42.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX42.MarketDataRequest.NoMDEntryTypesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.MarketDataRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX42.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX42.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.SecurityDefinition.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NumTickTblEntries: return new QuickFix.FIX42.SecurityDefinition.NumTickTblEntriesGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX42.SecurityDefinition.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoGateways: return new QuickFix.FIX42.SecurityDefinition.NoGatewaysGroup();
                    }
                }

                if (QuickFix.FIX42.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.NewOrderSingle.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX42.ExecutionReport.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.ExecutionReport.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoLinks: return new QuickFix.FIX42.ExecutionReport.NoLinksGroup();
                    }
                }

                if (QuickFix.FIX42.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.OrderCancelReplaceRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42.PositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX42.PositionReport.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.PositionReport.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoLinks: return new QuickFix.FIX42.PositionReport.NoLinksGroup();
                    }
                }

                if (QuickFix.FIX42.GatewayStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoGatewayStatus: return new QuickFix.FIX42.GatewayStatus.NoGatewayStatusGroup();
                    }
                }

                return null;
            }

        }
    }
}
