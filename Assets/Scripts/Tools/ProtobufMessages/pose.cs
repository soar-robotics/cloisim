// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: pose.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Pose : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name
        {
            get => __pbn__Name ?? "";
            set => __pbn__Name = value;
        }
        public bool ShouldSerializeName() => __pbn__Name != null;
        public void ResetName() => __pbn__Name = null;
        private string __pbn__Name;

        [global::ProtoBuf.ProtoMember(2, Name = @"id")]
        public uint Id
        {
            get => __pbn__Id.GetValueOrDefault();
            set => __pbn__Id = value;
        }
        public bool ShouldSerializeId() => __pbn__Id != null;
        public void ResetId() => __pbn__Id = null;
        private uint? __pbn__Id;

        [global::ProtoBuf.ProtoMember(3, Name = @"position", IsRequired = true)]
        public Vector3d Position { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"orientation", IsRequired = true)]
        public Quaternion Orientation { get; set; }

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
