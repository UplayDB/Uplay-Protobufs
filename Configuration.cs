// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: configuration.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Uplay.Configuration {

  /// <summary>Holder for reflection information generated from configuration.proto</summary>
  public static partial class ConfigurationReflection {

    #region Descriptor
    /// <summary>File descriptor for configuration.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigurationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch91cGNfZHVtcF8xMC9jb25maWd1cmF0aW9uLnByb3RvEhltZy5wcm90b2Nv",
            "bC5jb25maWd1cmF0aW9uIkwKDUNvbmZpZ3VyYXRpb24SEgoKcHJvZHVjdF9p",
            "ZBgBIAEoDRIQCgh1cGxheV9pZBgCIAEoDRIVCg1jb25maWd1cmF0aW9uGAMg",
            "AigJIlYKEkNvbmZpZ3VyYXRpb25DYWNoZRJACg5jb25maWd1cmF0aW9ucxgB",
            "IAMoCzIoLm1nLnByb3RvY29sLmNvbmZpZ3VyYXRpb24uQ29uZmlndXJhdGlv",
            "bg=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.Configuration.Configuration), global::Uplay.Configuration.Configuration.Parser, new[]{ "ProductId", "UplayId", "Configuration_" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.Configuration.ConfigurationCache), global::Uplay.Configuration.ConfigurationCache.Parser, new[]{ "Configurations" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Configuration : pb::IMessage<Configuration>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Configuration> _parser = new pb::MessageParser<Configuration>(() => new Configuration());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Configuration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.Configuration.ConfigurationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Configuration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Configuration(Configuration other) : this() {
      _hasBits0 = other._hasBits0;
      productId_ = other.productId_;
      uplayId_ = other.uplayId_;
      configuration_ = other.configuration_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Configuration Clone() {
      return new Configuration(this);
    }

    /// <summary>Field number for the "product_id" field.</summary>
    public const int ProductIdFieldNumber = 1;
    private readonly static uint ProductIdDefaultValue = 0;

    private uint productId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ProductId {
      get { if ((_hasBits0 & 1) != 0) { return productId_; } else { return ProductIdDefaultValue; } }
      set {
        _hasBits0 |= 1;
        productId_ = value;
      }
    }
    /// <summary>Gets whether the "product_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasProductId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "product_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearProductId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "uplay_id" field.</summary>
    public const int UplayIdFieldNumber = 2;
    private readonly static uint UplayIdDefaultValue = 0;

    private uint uplayId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UplayId {
      get { if ((_hasBits0 & 2) != 0) { return uplayId_; } else { return UplayIdDefaultValue; } }
      set {
        _hasBits0 |= 2;
        uplayId_ = value;
      }
    }
    /// <summary>Gets whether the "uplay_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasUplayId {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "uplay_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearUplayId() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "configuration" field.</summary>
    public const int Configuration_FieldNumber = 3;
    private readonly static string Configuration_DefaultValue = "";

    private string configuration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Configuration_ {
      get { return configuration_ ?? Configuration_DefaultValue; }
      set {
        configuration_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "configuration" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasConfiguration_ {
      get { return configuration_ != null; }
    }
    /// <summary>Clears the value of the "configuration" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearConfiguration_() {
      configuration_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Configuration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Configuration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProductId != other.ProductId) return false;
      if (UplayId != other.UplayId) return false;
      if (Configuration_ != other.Configuration_) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasProductId) hash ^= ProductId.GetHashCode();
      if (HasUplayId) hash ^= UplayId.GetHashCode();
      if (HasConfiguration_) hash ^= Configuration_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasProductId) {
        output.WriteRawTag(8);
        output.WriteUInt32(ProductId);
      }
      if (HasUplayId) {
        output.WriteRawTag(16);
        output.WriteUInt32(UplayId);
      }
      if (HasConfiguration_) {
        output.WriteRawTag(26);
        output.WriteString(Configuration_);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasProductId) {
        output.WriteRawTag(8);
        output.WriteUInt32(ProductId);
      }
      if (HasUplayId) {
        output.WriteRawTag(16);
        output.WriteUInt32(UplayId);
      }
      if (HasConfiguration_) {
        output.WriteRawTag(26);
        output.WriteString(Configuration_);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasProductId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ProductId);
      }
      if (HasUplayId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UplayId);
      }
      if (HasConfiguration_) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Configuration_);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Configuration other) {
      if (other == null) {
        return;
      }
      if (other.HasProductId) {
        ProductId = other.ProductId;
      }
      if (other.HasUplayId) {
        UplayId = other.UplayId;
      }
      if (other.HasConfiguration_) {
        Configuration_ = other.Configuration_;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ProductId = input.ReadUInt32();
            break;
          }
          case 16: {
            UplayId = input.ReadUInt32();
            break;
          }
          case 26: {
            Configuration_ = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ProductId = input.ReadUInt32();
            break;
          }
          case 16: {
            UplayId = input.ReadUInt32();
            break;
          }
          case 26: {
            Configuration_ = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ConfigurationCache : pb::IMessage<ConfigurationCache>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConfigurationCache> _parser = new pb::MessageParser<ConfigurationCache>(() => new ConfigurationCache());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConfigurationCache> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.Configuration.ConfigurationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfigurationCache() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfigurationCache(ConfigurationCache other) : this() {
      configurations_ = other.configurations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfigurationCache Clone() {
      return new ConfigurationCache(this);
    }

    /// <summary>Field number for the "configurations" field.</summary>
    public const int ConfigurationsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Uplay.Configuration.Configuration> _repeated_configurations_codec
        = pb::FieldCodec.ForMessage(10, global::Uplay.Configuration.Configuration.Parser);
    private readonly pbc::RepeatedField<global::Uplay.Configuration.Configuration> configurations_ = new pbc::RepeatedField<global::Uplay.Configuration.Configuration>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Uplay.Configuration.Configuration> Configurations {
      get { return configurations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConfigurationCache);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConfigurationCache other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!configurations_.Equals(other.configurations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= configurations_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      configurations_.WriteTo(output, _repeated_configurations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      configurations_.WriteTo(ref output, _repeated_configurations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += configurations_.CalculateSize(_repeated_configurations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ConfigurationCache other) {
      if (other == null) {
        return;
      }
      configurations_.Add(other.configurations_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            configurations_.AddEntriesFrom(input, _repeated_configurations_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            configurations_.AddEntriesFrom(ref input, _repeated_configurations_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
