// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: color.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Color : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"r", IsRequired = true)]
        public float R { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"g", IsRequired = true)]
        public float G { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"b", IsRequired = true)]
        public float B { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"a")]
        [global::System.ComponentModel.DefaultValue(1)]
        public float A
        {
            get => __pbn__A ?? 1;
            set => __pbn__A = value;
        }
        public bool ShouldSerializeA() => __pbn__A != null;
        public void ResetA() => __pbn__A = null;
        private float? __pbn__A;

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
