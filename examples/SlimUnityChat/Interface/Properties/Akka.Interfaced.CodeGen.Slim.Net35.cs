// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Akka.Interfaced CodeGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Akka.Interfaced;
using ProtoBuf;
using TypeAlias;
using System.ComponentModel;

#region SlimUnityChat.Interface.IOccupant

namespace SlimUnityChat.Interface
{
    public static class IOccupant_PayloadTable
    {
        public static Type[,] GetPayloadTypes()
        {
            return new Type[,]
            {
                {typeof(Say_Invoke), null},
                {typeof(GetHistory_Invoke), typeof(GetHistory_Return)},
                {typeof(Invite_Invoke), null},
            };
        }

        [ProtoContract, TypeAlias]
        public class Say_Invoke : IInterfacedPayload
        {
            [ProtoMember(1)] public System.String msg;
            [ProtoMember(2)] public System.String senderUserId;

            public Type GetInterfaceType() { return typeof(IOccupant); }
        }

        [ProtoContract, TypeAlias]
        public class GetHistory_Invoke : IInterfacedPayload
        {
            public Type GetInterfaceType() { return typeof(IOccupant); }
        }

        [ProtoContract, TypeAlias]
        public class GetHistory_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.Collections.Generic.List<SlimUnityChat.Interface.ChatItem> v;

            public Type GetInterfaceType() { return typeof(IOccupant); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class Invite_Invoke : IInterfacedPayload
        {
            [ProtoMember(1)] public System.String targetUserId;
            [ProtoMember(2)] public System.String senderUserId;

            public Type GetInterfaceType() { return typeof(IOccupant); }
        }
    }

    public interface IOccupant_NoReply
    {
        void Say(System.String msg, System.String senderUserId = null);
        void GetHistory();
        void Invite(System.String targetUserId, System.String senderUserId = null);
    }

    public class OccupantRef : InterfacedSlimActorRef, IOccupant, IOccupant_NoReply
    {
        public OccupantRef(ISlimActorRef actor, ISlimRequestWaiter requestWaiter, TimeSpan? timeout)
            : base(actor, requestWaiter, timeout)
        {
        }

        public IOccupant_NoReply WithNoReply()
        {
            return this;
        }

        public OccupantRef WithRequestWaiter(ISlimRequestWaiter requestWaiter)
        {
            return new OccupantRef(Actor, requestWaiter, Timeout);
        }

        public OccupantRef WithTimeout(TimeSpan? timeout)
        {
            return new OccupantRef(Actor, RequestWaiter, timeout);
        }

        public Task Say(System.String msg, System.String senderUserId = null)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IOccupant_PayloadTable.Say_Invoke { msg = msg, senderUserId = senderUserId }
            };
            return SendRequestAndWait(requestMessage);
        }

        public Task<System.Collections.Generic.List<SlimUnityChat.Interface.ChatItem>> GetHistory()
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IOccupant_PayloadTable.GetHistory_Invoke {  }
            };
            return SendRequestAndReceive<System.Collections.Generic.List<SlimUnityChat.Interface.ChatItem>>(requestMessage);
        }

        public Task Invite(System.String targetUserId, System.String senderUserId = null)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IOccupant_PayloadTable.Invite_Invoke { targetUserId = targetUserId, senderUserId = senderUserId }
            };
            return SendRequestAndWait(requestMessage);
        }

        void IOccupant_NoReply.Say(System.String msg, System.String senderUserId)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IOccupant_PayloadTable.Say_Invoke { msg = msg, senderUserId = senderUserId }
            };
            SendRequest(requestMessage);
        }

        void IOccupant_NoReply.GetHistory()
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IOccupant_PayloadTable.GetHistory_Invoke {  }
            };
            SendRequest(requestMessage);
        }

        void IOccupant_NoReply.Invite(System.String targetUserId, System.String senderUserId)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IOccupant_PayloadTable.Invite_Invoke { targetUserId = targetUserId, senderUserId = senderUserId }
            };
            SendRequest(requestMessage);
        }
    }
}

#endregion

#region SlimUnityChat.Interface.IUser

namespace SlimUnityChat.Interface
{
    public static class IUser_PayloadTable
    {
        public static Type[,] GetPayloadTypes()
        {
            return new Type[,]
            {
                {typeof(GetId_Invoke), typeof(GetId_Return)},
                {typeof(GetRoomList_Invoke), typeof(GetRoomList_Return)},
                {typeof(EnterRoom_Invoke), typeof(EnterRoom_Return)},
                {typeof(ExitFromRoom_Invoke), null},
                {typeof(Whisper_Invoke), null},
            };
        }

        [ProtoContract, TypeAlias]
        public class GetId_Invoke : IInterfacedPayload
        {
            public Type GetInterfaceType() { return typeof(IUser); }
        }

        [ProtoContract, TypeAlias]
        public class GetId_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.String v;

            public Type GetInterfaceType() { return typeof(IUser); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class GetRoomList_Invoke : IInterfacedPayload
        {
            public Type GetInterfaceType() { return typeof(IUser); }
        }

        [ProtoContract, TypeAlias]
        public class GetRoomList_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.Collections.Generic.List<System.String> v;

            public Type GetInterfaceType() { return typeof(IUser); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class EnterRoom_Invoke : IInterfacedPayload
        {
            [ProtoMember(1)] public System.String name;
            [ProtoMember(2)] public System.Int32 observerId;

            public Type GetInterfaceType() { return typeof(IUser); }
        }

        [ProtoContract, TypeAlias]
        public class EnterRoom_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.Tuple<System.Int32, SlimUnityChat.Interface.RoomInfo> v;

            public Type GetInterfaceType() { return typeof(IUser); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class ExitFromRoom_Invoke : IInterfacedPayload
        {
            [ProtoMember(1)] public System.String name;

            public Type GetInterfaceType() { return typeof(IUser); }
        }

        [ProtoContract, TypeAlias]
        public class Whisper_Invoke : IInterfacedPayload
        {
            [ProtoMember(1)] public System.String targetUserId;
            [ProtoMember(2)] public System.String message;

            public Type GetInterfaceType() { return typeof(IUser); }
        }
    }

    public interface IUser_NoReply
    {
        void GetId();
        void GetRoomList();
        void EnterRoom(System.String name, System.Int32 observerId);
        void ExitFromRoom(System.String name);
        void Whisper(System.String targetUserId, System.String message);
    }

    public class UserRef : InterfacedSlimActorRef, IUser, IUser_NoReply
    {
        public UserRef(ISlimActorRef actor, ISlimRequestWaiter requestWaiter, TimeSpan? timeout)
            : base(actor, requestWaiter, timeout)
        {
        }

        public IUser_NoReply WithNoReply()
        {
            return this;
        }

        public UserRef WithRequestWaiter(ISlimRequestWaiter requestWaiter)
        {
            return new UserRef(Actor, requestWaiter, Timeout);
        }

        public UserRef WithTimeout(TimeSpan? timeout)
        {
            return new UserRef(Actor, RequestWaiter, timeout);
        }

        public Task<System.String> GetId()
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUser_PayloadTable.GetId_Invoke {  }
            };
            return SendRequestAndReceive<System.String>(requestMessage);
        }

        public Task<System.Collections.Generic.List<System.String>> GetRoomList()
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUser_PayloadTable.GetRoomList_Invoke {  }
            };
            return SendRequestAndReceive<System.Collections.Generic.List<System.String>>(requestMessage);
        }

        public Task<System.Tuple<System.Int32, SlimUnityChat.Interface.RoomInfo>> EnterRoom(System.String name, System.Int32 observerId)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUser_PayloadTable.EnterRoom_Invoke { name = name, observerId = observerId }
            };
            return SendRequestAndReceive<System.Tuple<System.Int32, SlimUnityChat.Interface.RoomInfo>>(requestMessage);
        }

        public Task ExitFromRoom(System.String name)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUser_PayloadTable.ExitFromRoom_Invoke { name = name }
            };
            return SendRequestAndWait(requestMessage);
        }

        public Task Whisper(System.String targetUserId, System.String message)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUser_PayloadTable.Whisper_Invoke { targetUserId = targetUserId, message = message }
            };
            return SendRequestAndWait(requestMessage);
        }

        void IUser_NoReply.GetId()
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUser_PayloadTable.GetId_Invoke {  }
            };
            SendRequest(requestMessage);
        }

        void IUser_NoReply.GetRoomList()
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUser_PayloadTable.GetRoomList_Invoke {  }
            };
            SendRequest(requestMessage);
        }

        void IUser_NoReply.EnterRoom(System.String name, System.Int32 observerId)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUser_PayloadTable.EnterRoom_Invoke { name = name, observerId = observerId }
            };
            SendRequest(requestMessage);
        }

        void IUser_NoReply.ExitFromRoom(System.String name)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUser_PayloadTable.ExitFromRoom_Invoke { name = name }
            };
            SendRequest(requestMessage);
        }

        void IUser_NoReply.Whisper(System.String targetUserId, System.String message)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUser_PayloadTable.Whisper_Invoke { targetUserId = targetUserId, message = message }
            };
            SendRequest(requestMessage);
        }
    }
}

#endregion

#region SlimUnityChat.Interface.IUserLogin

namespace SlimUnityChat.Interface
{
    public static class IUserLogin_PayloadTable
    {
        public static Type[,] GetPayloadTypes()
        {
            return new Type[,]
            {
                {typeof(Login_Invoke), typeof(Login_Return)},
            };
        }

        [ProtoContract, TypeAlias]
        public class Login_Invoke : IInterfacedPayload
        {
            [ProtoMember(1)] public System.String id;
            [ProtoMember(2)] public System.String password;
            [ProtoMember(3)] public System.Int32 observerId;

            public Type GetInterfaceType() { return typeof(IUserLogin); }
        }

        [ProtoContract, TypeAlias]
        public class Login_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.Int32 v;

            public Type GetInterfaceType() { return typeof(IUserLogin); }

            public object Value { get { return v; } }
        }
    }

    public interface IUserLogin_NoReply
    {
        void Login(System.String id, System.String password, System.Int32 observerId);
    }

    public class UserLoginRef : InterfacedSlimActorRef, IUserLogin, IUserLogin_NoReply
    {
        public UserLoginRef(ISlimActorRef actor, ISlimRequestWaiter requestWaiter, TimeSpan? timeout)
            : base(actor, requestWaiter, timeout)
        {
        }

        public IUserLogin_NoReply WithNoReply()
        {
            return this;
        }

        public UserLoginRef WithRequestWaiter(ISlimRequestWaiter requestWaiter)
        {
            return new UserLoginRef(Actor, requestWaiter, Timeout);
        }

        public UserLoginRef WithTimeout(TimeSpan? timeout)
        {
            return new UserLoginRef(Actor, RequestWaiter, timeout);
        }

        public Task<System.Int32> Login(System.String id, System.String password, System.Int32 observerId)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUserLogin_PayloadTable.Login_Invoke { id = id, password = password, observerId = observerId }
            };
            return SendRequestAndReceive<System.Int32>(requestMessage);
        }

        void IUserLogin_NoReply.Login(System.String id, System.String password, System.Int32 observerId)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUserLogin_PayloadTable.Login_Invoke { id = id, password = password, observerId = observerId }
            };
            SendRequest(requestMessage);
        }
    }
}

#endregion

#region SlimUnityChat.Interface.IUserMessasing

namespace SlimUnityChat.Interface
{
    public static class IUserMessasing_PayloadTable
    {
        public static Type[,] GetPayloadTypes()
        {
            return new Type[,]
            {
                {typeof(Whisper_Invoke), null},
                {typeof(Invite_Invoke), null},
            };
        }

        [ProtoContract, TypeAlias]
        public class Whisper_Invoke : IInterfacedPayload
        {
            [ProtoMember(1)] public SlimUnityChat.Interface.ChatItem chatItem;

            public Type GetInterfaceType() { return typeof(IUserMessasing); }
        }

        [ProtoContract, TypeAlias]
        public class Invite_Invoke : IInterfacedPayload
        {
            [ProtoMember(1)] public System.String invitorUserId;
            [ProtoMember(2)] public System.String roomName;

            public Type GetInterfaceType() { return typeof(IUserMessasing); }
        }
    }

    public interface IUserMessasing_NoReply
    {
        void Whisper(SlimUnityChat.Interface.ChatItem chatItem);
        void Invite(System.String invitorUserId, System.String roomName);
    }

    public class UserMessasingRef : InterfacedSlimActorRef, IUserMessasing, IUserMessasing_NoReply
    {
        public UserMessasingRef(ISlimActorRef actor, ISlimRequestWaiter requestWaiter, TimeSpan? timeout)
            : base(actor, requestWaiter, timeout)
        {
        }

        public IUserMessasing_NoReply WithNoReply()
        {
            return this;
        }

        public UserMessasingRef WithRequestWaiter(ISlimRequestWaiter requestWaiter)
        {
            return new UserMessasingRef(Actor, requestWaiter, Timeout);
        }

        public UserMessasingRef WithTimeout(TimeSpan? timeout)
        {
            return new UserMessasingRef(Actor, RequestWaiter, timeout);
        }

        public Task Whisper(SlimUnityChat.Interface.ChatItem chatItem)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUserMessasing_PayloadTable.Whisper_Invoke { chatItem = chatItem }
            };
            return SendRequestAndWait(requestMessage);
        }

        public Task Invite(System.String invitorUserId, System.String roomName)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUserMessasing_PayloadTable.Invite_Invoke { invitorUserId = invitorUserId, roomName = roomName }
            };
            return SendRequestAndWait(requestMessage);
        }

        void IUserMessasing_NoReply.Whisper(SlimUnityChat.Interface.ChatItem chatItem)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUserMessasing_PayloadTable.Whisper_Invoke { chatItem = chatItem }
            };
            SendRequest(requestMessage);
        }

        void IUserMessasing_NoReply.Invite(System.String invitorUserId, System.String roomName)
        {
            var requestMessage = new SlimRequestMessage
            {
                InvokePayload = new IUserMessasing_PayloadTable.Invite_Invoke { invitorUserId = invitorUserId, roomName = roomName }
            };
            SendRequest(requestMessage);
        }
    }
}

#endregion

#region SlimUnityChat.Interface.IRoomObserver

namespace SlimUnityChat.Interface
{
    public static class IRoomObserver_PayloadTable
    {
        [ProtoContract, TypeAlias]
        public class Enter_Invoke : IInvokable
        {
            [ProtoMember(1)] public System.String userId;

            public void Invoke(object target)
            {
                ((IRoomObserver)target).Enter(userId);
            }
        }

        [ProtoContract, TypeAlias]
        public class Exit_Invoke : IInvokable
        {
            [ProtoMember(1)] public System.String userId;

            public void Invoke(object target)
            {
                ((IRoomObserver)target).Exit(userId);
            }
        }

        [ProtoContract, TypeAlias]
        public class Say_Invoke : IInvokable
        {
            [ProtoMember(1)] public SlimUnityChat.Interface.ChatItem chatItem;

            public void Invoke(object target)
            {
                ((IRoomObserver)target).Say(chatItem);
            }
        }
    }
}

#endregion

#region SlimUnityChat.Interface.IUserEventObserver

namespace SlimUnityChat.Interface
{
    public static class IUserEventObserver_PayloadTable
    {
        [ProtoContract, TypeAlias]
        public class Whisper_Invoke : IInvokable
        {
            [ProtoMember(1)] public SlimUnityChat.Interface.ChatItem chatItem;

            public void Invoke(object target)
            {
                ((IUserEventObserver)target).Whisper(chatItem);
            }
        }

        [ProtoContract, TypeAlias]
        public class Invite_Invoke : IInvokable
        {
            [ProtoMember(1)] public System.String invitorUserId;
            [ProtoMember(2)] public System.String roomName;

            public void Invoke(object target)
            {
                ((IUserEventObserver)target).Invite(invitorUserId, roomName);
            }
        }
    }
}

#endregion
