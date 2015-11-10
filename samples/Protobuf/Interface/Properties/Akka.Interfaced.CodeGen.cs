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
using Akka.Actor;
using Akka.Interfaced;
using ProtoBuf;
using TypeAlias;
using System.ComponentModel;

#region Protobuf.Interface.IHelloWorld

namespace Protobuf.Interface
{
    [PayloadTableForInterfacedActor(typeof(IHelloWorld))]
    public static class IHelloWorld_PayloadTable
    {
        public static Type[,] GetPayloadTypes()
        {
            return new Type[,]
            {
                {typeof(GetHelloCount_Invoke), typeof(GetHelloCount_Return)},
                {typeof(SayHello_Invoke), typeof(SayHello_Return)},
            };
        }

        [ProtoContract, TypeAlias]
        public class GetHelloCount_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            public Type GetInterfaceType() { return typeof(IHelloWorld); }

            public async Task<IValueGetable> InvokeAsync(object target)
            {
                var __v = await((IHelloWorld)target).GetHelloCount();
                return (IValueGetable)(new GetHelloCount_Return { v = __v });
            }
        }

        [ProtoContract, TypeAlias]
        public class GetHelloCount_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.Int32 v;

            public Type GetInterfaceType() { return typeof(IHelloWorld); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class SayHello_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            [ProtoMember(1)] public System.String name;

            public Type GetInterfaceType() { return typeof(IHelloWorld); }

            public async Task<IValueGetable> InvokeAsync(object target)
            {
                var __v = await((IHelloWorld)target).SayHello(name);
                return (IValueGetable)(new SayHello_Return { v = __v });
            }
        }

        [ProtoContract, TypeAlias]
        public class SayHello_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.String v;

            public Type GetInterfaceType() { return typeof(IHelloWorld); }

            public object Value { get { return v; } }
        }
    }

    public interface IHelloWorld_NoReply
    {
        void GetHelloCount();
        void SayHello(System.String name);
    }

    [ProtoContract, TypeAlias]
    public class HelloWorldRef : InterfacedActorRef, IHelloWorld, IHelloWorld_NoReply
    {
        [ProtoMember(1)] private ActorRefBase _actor
        {
            get { return (ActorRefBase)Actor; }
            set { Actor = value; }
        }

        private HelloWorldRef()
            : base(null)
        {
        }

        public HelloWorldRef(IActorRef actor)
            : base(actor)
        {
        }

        public HelloWorldRef(IActorRef actor, IRequestWaiter requestWaiter, TimeSpan? timeout)
            : base(actor, requestWaiter, timeout)
        {
        }

        public IHelloWorld_NoReply WithNoReply()
        {
            return this;
        }

        public HelloWorldRef WithRequestWaiter(IRequestWaiter requestWaiter)
        {
            return new HelloWorldRef(Actor, requestWaiter, Timeout);
        }

        public HelloWorldRef WithTimeout(TimeSpan? timeout)
        {
            return new HelloWorldRef(Actor, RequestWaiter, timeout);
        }

        public Task<System.Int32> GetHelloCount()
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IHelloWorld_PayloadTable.GetHelloCount_Invoke {  }
            };
            return SendRequestAndReceive<System.Int32>(requestMessage);
        }

        public Task<System.String> SayHello(System.String name)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IHelloWorld_PayloadTable.SayHello_Invoke { name = name }
            };
            return SendRequestAndReceive<System.String>(requestMessage);
        }

        void IHelloWorld_NoReply.GetHelloCount()
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IHelloWorld_PayloadTable.GetHelloCount_Invoke {  }
            };
            SendRequest(requestMessage);
        }

        void IHelloWorld_NoReply.SayHello(System.String name)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IHelloWorld_PayloadTable.SayHello_Invoke { name = name }
            };
            SendRequest(requestMessage);
        }
    }
}

#endregion

#region Protobuf.Interface.IPedantic

namespace Protobuf.Interface
{
    [PayloadTableForInterfacedActor(typeof(IPedantic))]
    public static class IPedantic_PayloadTable
    {
        public static Type[,] GetPayloadTypes()
        {
            return new Type[,]
            {
                {typeof(TestCall_Invoke), null},
                {typeof(TestOptional_Invoke), typeof(TestOptional_Return)},
                {typeof(TestParams_Invoke), typeof(TestParams_Return)},
                {typeof(TestPassClass_Invoke), typeof(TestPassClass_Return)},
                {typeof(TestReturnClass_Invoke), typeof(TestReturnClass_Return)},
                {typeof(TestTuple_Invoke), typeof(TestTuple_Return)},
            };
        }

        [ProtoContract, TypeAlias]
        public class TestCall_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            public Type GetInterfaceType() { return typeof(IPedantic); }

            public async Task<IValueGetable> InvokeAsync(object target)
            {
                await ((IPedantic)target).TestCall();
                return null;
            }
        }

        [ProtoContract, TypeAlias]
        public class TestOptional_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            [ProtoMember(1)] public System.Nullable<System.Int32> value;

            public Type GetInterfaceType() { return typeof(IPedantic); }

            public async Task<IValueGetable> InvokeAsync(object target)
            {
                var __v = await((IPedantic)target).TestOptional(value);
                return (IValueGetable)(new TestOptional_Return { v = (System.Nullable<System.Int32>)__v });
            }
        }

        [ProtoContract, TypeAlias]
        public class TestOptional_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.Nullable<System.Int32> v;

            public Type GetInterfaceType() { return typeof(IPedantic); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class TestParams_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            [ProtoMember(1)] public System.Int32[] values;

            public Type GetInterfaceType() { return typeof(IPedantic); }

            public async Task<IValueGetable> InvokeAsync(object target)
            {
                var __v = await((IPedantic)target).TestParams(values);
                return (IValueGetable)(new TestParams_Return { v = __v });
            }
        }

        [ProtoContract, TypeAlias]
        public class TestParams_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.Int32[] v;

            public Type GetInterfaceType() { return typeof(IPedantic); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class TestPassClass_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            [ProtoMember(1)] public Protobuf.Interface.TestParam param;

            public Type GetInterfaceType() { return typeof(IPedantic); }

            public async Task<IValueGetable> InvokeAsync(object target)
            {
                var __v = await((IPedantic)target).TestPassClass(param);
                return (IValueGetable)(new TestPassClass_Return { v = __v });
            }
        }

        [ProtoContract, TypeAlias]
        public class TestPassClass_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.String v;

            public Type GetInterfaceType() { return typeof(IPedantic); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class TestReturnClass_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            [ProtoMember(1)] public System.Int32 value;
            [ProtoMember(2)] public System.Int32 offset;

            public Type GetInterfaceType() { return typeof(IPedantic); }

            public async Task<IValueGetable> InvokeAsync(object target)
            {
                var __v = await((IPedantic)target).TestReturnClass(value, offset);
                return (IValueGetable)(new TestReturnClass_Return { v = __v });
            }
        }

        [ProtoContract, TypeAlias]
        public class TestReturnClass_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public Protobuf.Interface.TestResult v;

            public Type GetInterfaceType() { return typeof(IPedantic); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class TestTuple_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            [ProtoMember(1)] public System.Tuple<System.Int32, System.String> value;

            public Type GetInterfaceType() { return typeof(IPedantic); }

            public async Task<IValueGetable> InvokeAsync(object target)
            {
                var __v = await((IPedantic)target).TestTuple(value);
                return (IValueGetable)(new TestTuple_Return { v = (System.Tuple<System.Int32, System.String>)__v });
            }
        }

        [ProtoContract, TypeAlias]
        public class TestTuple_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public System.Tuple<System.Int32, System.String> v;

            public Type GetInterfaceType() { return typeof(IPedantic); }

            public object Value { get { return v; } }
        }
    }

    public interface IPedantic_NoReply
    {
        void TestCall();
        void TestOptional(System.Nullable<System.Int32> value);
        void TestParams(params System.Int32[] values);
        void TestPassClass(Protobuf.Interface.TestParam param);
        void TestReturnClass(System.Int32 value, System.Int32 offset);
        void TestTuple(System.Tuple<System.Int32, System.String> value);
    }

    [ProtoContract, TypeAlias]
    public class PedanticRef : InterfacedActorRef, IPedantic, IPedantic_NoReply
    {
        [ProtoMember(1)] private ActorRefBase _actor
        {
            get { return (ActorRefBase)Actor; }
            set { Actor = value; }
        }

        private PedanticRef()
            : base(null)
        {
        }

        public PedanticRef(IActorRef actor)
            : base(actor)
        {
        }

        public PedanticRef(IActorRef actor, IRequestWaiter requestWaiter, TimeSpan? timeout)
            : base(actor, requestWaiter, timeout)
        {
        }

        public IPedantic_NoReply WithNoReply()
        {
            return this;
        }

        public PedanticRef WithRequestWaiter(IRequestWaiter requestWaiter)
        {
            return new PedanticRef(Actor, requestWaiter, Timeout);
        }

        public PedanticRef WithTimeout(TimeSpan? timeout)
        {
            return new PedanticRef(Actor, RequestWaiter, timeout);
        }

        public Task TestCall()
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestCall_Invoke {  }
            };
            return SendRequestAndWait(requestMessage);
        }

        public Task<System.Nullable<System.Int32>> TestOptional(System.Nullable<System.Int32> value)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestOptional_Invoke { value = (System.Nullable<System.Int32>)value }
            };
            return SendRequestAndReceive<System.Nullable<System.Int32>>(requestMessage);
        }

        public Task<System.Int32[]> TestParams(params System.Int32[] values)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestParams_Invoke { values = values }
            };
            return SendRequestAndReceive<System.Int32[]>(requestMessage);
        }

        public Task<System.String> TestPassClass(Protobuf.Interface.TestParam param)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestPassClass_Invoke { param = param }
            };
            return SendRequestAndReceive<System.String>(requestMessage);
        }

        public Task<Protobuf.Interface.TestResult> TestReturnClass(System.Int32 value, System.Int32 offset)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestReturnClass_Invoke { value = value, offset = offset }
            };
            return SendRequestAndReceive<Protobuf.Interface.TestResult>(requestMessage);
        }

        public Task<System.Tuple<System.Int32, System.String>> TestTuple(System.Tuple<System.Int32, System.String> value)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestTuple_Invoke { value = (System.Tuple<System.Int32, System.String>)value }
            };
            return SendRequestAndReceive<System.Tuple<System.Int32, System.String>>(requestMessage);
        }

        void IPedantic_NoReply.TestCall()
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestCall_Invoke {  }
            };
            SendRequest(requestMessage);
        }

        void IPedantic_NoReply.TestOptional(System.Nullable<System.Int32> value)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestOptional_Invoke { value = (System.Nullable<System.Int32>)value }
            };
            SendRequest(requestMessage);
        }

        void IPedantic_NoReply.TestParams(params System.Int32[] values)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestParams_Invoke { values = values }
            };
            SendRequest(requestMessage);
        }

        void IPedantic_NoReply.TestPassClass(Protobuf.Interface.TestParam param)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestPassClass_Invoke { param = param }
            };
            SendRequest(requestMessage);
        }

        void IPedantic_NoReply.TestReturnClass(System.Int32 value, System.Int32 offset)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestReturnClass_Invoke { value = value, offset = offset }
            };
            SendRequest(requestMessage);
        }

        void IPedantic_NoReply.TestTuple(System.Tuple<System.Int32, System.String> value)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new IPedantic_PayloadTable.TestTuple_Invoke { value = (System.Tuple<System.Int32, System.String>)value }
            };
            SendRequest(requestMessage);
        }
    }
}

#endregion

#region Protobuf.Interface.ISurrogate

namespace Protobuf.Interface
{
    [PayloadTableForInterfacedActor(typeof(ISurrogate))]
    public static class ISurrogate_PayloadTable
    {
        public static Type[,] GetPayloadTypes()
        {
            return new Type[,]
            {
                {typeof(GetAddress_Invoke), typeof(GetAddress_Return)},
                {typeof(GetPath_Invoke), typeof(GetPath_Return)},
                {typeof(GetSelf_Invoke), typeof(GetSelf_Return)},
            };
        }

        [ProtoContract, TypeAlias]
        public class GetAddress_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            [ProtoMember(1)] public Akka.Actor.Address address;

            public Type GetInterfaceType() { return typeof(ISurrogate); }

            public async Task<IValueGetable> InvokeAsync(object target)
            {
                var __v = await((ISurrogate)target).GetAddress(address);
                return (IValueGetable)(new GetAddress_Return { v = __v });
            }
        }

        [ProtoContract, TypeAlias]
        public class GetAddress_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public Akka.Actor.Address v;

            public Type GetInterfaceType() { return typeof(ISurrogate); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class GetPath_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            [ProtoMember(1)] public Akka.Actor.ActorPath path;

            public Type GetInterfaceType() { return typeof(ISurrogate); }

            public async Task<IValueGetable> InvokeAsync(object target)
            {
                var __v = await((ISurrogate)target).GetPath(path);
                return (IValueGetable)(new GetPath_Return { v = __v });
            }
        }

        [ProtoContract, TypeAlias]
        public class GetPath_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public Akka.Actor.ActorPath v;

            public Type GetInterfaceType() { return typeof(ISurrogate); }

            public object Value { get { return v; } }
        }

        [ProtoContract, TypeAlias]
        public class GetSelf_Invoke : IInterfacedPayload, IAsyncInvokable
        {
            public Type GetInterfaceType() { return typeof(ISurrogate); }

            public async Task<IValueGetable> InvokeAsync(object target)
            {
                var __v = await((ISurrogate)target).GetSelf();
                return (IValueGetable)(new GetSelf_Return { v = __v });
            }
        }

        [ProtoContract, TypeAlias]
        public class GetSelf_Return : IInterfacedPayload, IValueGetable
        {
            [ProtoMember(1)] public Akka.Actor.ActorRefBase v;

            public Type GetInterfaceType() { return typeof(ISurrogate); }

            public object Value { get { return v; } }
        }
    }

    public interface ISurrogate_NoReply
    {
        void GetAddress(Akka.Actor.Address address);
        void GetPath(Akka.Actor.ActorPath path);
        void GetSelf();
    }

    [ProtoContract, TypeAlias]
    public class SurrogateRef : InterfacedActorRef, ISurrogate, ISurrogate_NoReply
    {
        [ProtoMember(1)] private ActorRefBase _actor
        {
            get { return (ActorRefBase)Actor; }
            set { Actor = value; }
        }

        private SurrogateRef()
            : base(null)
        {
        }

        public SurrogateRef(IActorRef actor)
            : base(actor)
        {
        }

        public SurrogateRef(IActorRef actor, IRequestWaiter requestWaiter, TimeSpan? timeout)
            : base(actor, requestWaiter, timeout)
        {
        }

        public ISurrogate_NoReply WithNoReply()
        {
            return this;
        }

        public SurrogateRef WithRequestWaiter(IRequestWaiter requestWaiter)
        {
            return new SurrogateRef(Actor, requestWaiter, Timeout);
        }

        public SurrogateRef WithTimeout(TimeSpan? timeout)
        {
            return new SurrogateRef(Actor, RequestWaiter, timeout);
        }

        public Task<Akka.Actor.Address> GetAddress(Akka.Actor.Address address)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new ISurrogate_PayloadTable.GetAddress_Invoke { address = address }
            };
            return SendRequestAndReceive<Akka.Actor.Address>(requestMessage);
        }

        public Task<Akka.Actor.ActorPath> GetPath(Akka.Actor.ActorPath path)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new ISurrogate_PayloadTable.GetPath_Invoke { path = path }
            };
            return SendRequestAndReceive<Akka.Actor.ActorPath>(requestMessage);
        }

        public Task<Akka.Actor.ActorRefBase> GetSelf()
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new ISurrogate_PayloadTable.GetSelf_Invoke {  }
            };
            return SendRequestAndReceive<Akka.Actor.ActorRefBase>(requestMessage);
        }

        void ISurrogate_NoReply.GetAddress(Akka.Actor.Address address)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new ISurrogate_PayloadTable.GetAddress_Invoke { address = address }
            };
            SendRequest(requestMessage);
        }

        void ISurrogate_NoReply.GetPath(Akka.Actor.ActorPath path)
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new ISurrogate_PayloadTable.GetPath_Invoke { path = path }
            };
            SendRequest(requestMessage);
        }

        void ISurrogate_NoReply.GetSelf()
        {
            var requestMessage = new RequestMessage
            {
                InvokePayload = new ISurrogate_PayloadTable.GetSelf_Invoke {  }
            };
            SendRequest(requestMessage);
        }
    }
}

#endregion