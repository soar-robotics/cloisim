// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: poses_stamped.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PosesStamped : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"time", IsRequired = true)]
        public Time Time { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"pose")]
        public global::System.Collections.Generic.List<Pose> Poses { get; } = new global::System.Collections.Generic.List<Pose>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
