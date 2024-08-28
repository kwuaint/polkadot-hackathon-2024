//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.NetApi.Generated.Model.frame_system
{
    
    
    /// <summary>
    /// >> 18 - Composite[frame_system.EventRecord]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class EventRecord : BaseType
    {
        
        /// <summary>
        /// >> phase
        /// </summary>
        private Substrate.NetApi.Generated.Model.frame_system.EnumPhase _phase;
        
        /// <summary>
        /// >> event
        /// </summary>
        private Substrate.NetApi.Generated.Model.polkadot_runtime.EnumRuntimeEvent _event;
        
        /// <summary>
        /// >> topics
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Generated.Model.primitive_types.H256> _topics;
        
        public Substrate.NetApi.Generated.Model.frame_system.EnumPhase Phase
        {
            get
            {
                return this._phase;
            }
            set
            {
                this._phase = value;
            }
        }
        
        public Substrate.NetApi.Generated.Model.polkadot_runtime.EnumRuntimeEvent Event
        {
            get
            {
                return this._event;
            }
            set
            {
                this._event = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Generated.Model.primitive_types.H256> Topics
        {
            get
            {
                return this._topics;
            }
            set
            {
                this._topics = value;
            }
        }
        
        public override string TypeName()
        {
            return "EventRecord";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Phase.Encode());
            result.AddRange(Event.Encode());
            result.AddRange(Topics.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Phase = new Substrate.NetApi.Generated.Model.frame_system.EnumPhase();
            Phase.Decode(byteArray, ref p);
            Event = new Substrate.NetApi.Generated.Model.polkadot_runtime.EnumRuntimeEvent();
            Event.Decode(byteArray, ref p);
            Topics = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Generated.Model.primitive_types.H256>();
            Topics.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}