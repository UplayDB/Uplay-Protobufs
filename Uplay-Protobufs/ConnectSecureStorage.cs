// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: connect_secure_storage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Uplay.ConnectSecureStorage {

  /// <summary>Holder for reflection information generated from connect_secure_storage.proto</summary>
  public static partial class ConnectSecureStorageReflection {

    #region Descriptor
    /// <summary>File descriptor for connect_secure_storage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConnectSecureStorageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chxjb25uZWN0X3NlY3VyZV9zdG9yYWdlLnByb3RvEiJtZy5wcm90b2NvbC5j",
            "b25uZWN0X3NlY3VyZV9zdG9yYWdlIkEKBUVudHJ5EhEKCWlzUHJpdmF0ZRgB",
            "IAEoCBIWCg5leHBpcmF0aW9uVGltZRgCIAEoBBINCgV2YWx1ZRgDIAEoDCK+",
            "AQoNU3BhY2VJZEJ1Y2tldBJRCghlbGVtZW50cxgBIAMoCzI/Lm1nLnByb3Rv",
            "Y29sLmNvbm5lY3Rfc2VjdXJlX3N0b3JhZ2UuU3BhY2VJZEJ1Y2tldC5FbGVt",
            "ZW50c0VudHJ5GloKDUVsZW1lbnRzRW50cnkSCwoDa2V5GAEgASgJEjgKBXZh",
            "bHVlGAIgASgLMikubWcucHJvdG9jb2wuY29ubmVjdF9zZWN1cmVfc3RvcmFn",
            "ZS5FbnRyeToCOAEiugEKDVNlY3VyZVN0b3JhZ2USSQoEZGF0YRgBIAMoCzI7",
            "Lm1nLnByb3RvY29sLmNvbm5lY3Rfc2VjdXJlX3N0b3JhZ2UuU2VjdXJlU3Rv",
            "cmFnZS5EYXRhRW50cnkaXgoJRGF0YUVudHJ5EgsKA2tleRgBIAEoCRJACgV2",
            "YWx1ZRgCIAEoCzIxLm1nLnByb3RvY29sLmNvbm5lY3Rfc2VjdXJlX3N0b3Jh",
            "Z2UuU3BhY2VJZEJ1Y2tldDoCOAEi5wEKBUNhY2hlEkEKBHByb2QYASABKAsy",
            "MS5tZy5wcm90b2NvbC5jb25uZWN0X3NlY3VyZV9zdG9yYWdlLlNlY3VyZVN0",
            "b3JhZ2VIABJACgN1YXQYAiABKAsyMS5tZy5wcm90b2NvbC5jb25uZWN0X3Nl",
            "Y3VyZV9zdG9yYWdlLlNlY3VyZVN0b3JhZ2VIARJACgNkZXYYAyABKAsyMS5t",
            "Zy5wcm90b2NvbC5jb25uZWN0X3NlY3VyZV9zdG9yYWdlLlNlY3VyZVN0b3Jh",
            "Z2VIAkIHCgVfcHJvZEIGCgRfdWF0QgYKBF9kZXZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.ConnectSecureStorage.Entry), global::Uplay.ConnectSecureStorage.Entry.Parser, new[]{ "IsPrivate", "ExpirationTime", "Value" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.ConnectSecureStorage.SpaceIdBucket), global::Uplay.ConnectSecureStorage.SpaceIdBucket.Parser, new[]{ "Elements" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.ConnectSecureStorage.SecureStorage), global::Uplay.ConnectSecureStorage.SecureStorage.Parser, new[]{ "Data" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.ConnectSecureStorage.Cache), global::Uplay.ConnectSecureStorage.Cache.Parser, new[]{ "Prod", "Uat", "Dev" }, new[]{ "Prod", "Uat", "Dev" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Entry : pb::IMessage<Entry>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Entry> _parser = new pb::MessageParser<Entry>(() => new Entry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Entry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.ConnectSecureStorage.ConnectSecureStorageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Entry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Entry(Entry other) : this() {
      isPrivate_ = other.isPrivate_;
      expirationTime_ = other.expirationTime_;
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Entry Clone() {
      return new Entry(this);
    }

    /// <summary>Field number for the "isPrivate" field.</summary>
    public const int IsPrivateFieldNumber = 1;
    private bool isPrivate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPrivate {
      get { return isPrivate_; }
      set {
        isPrivate_ = value;
      }
    }

    /// <summary>Field number for the "expirationTime" field.</summary>
    public const int ExpirationTimeFieldNumber = 2;
    private ulong expirationTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ExpirationTime {
      get { return expirationTime_; }
      set {
        expirationTime_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 3;
    private pb::ByteString value_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Entry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Entry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsPrivate != other.IsPrivate) return false;
      if (ExpirationTime != other.ExpirationTime) return false;
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsPrivate != false) hash ^= IsPrivate.GetHashCode();
      if (ExpirationTime != 0UL) hash ^= ExpirationTime.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
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
      if (IsPrivate != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsPrivate);
      }
      if (ExpirationTime != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ExpirationTime);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Value);
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
      if (IsPrivate != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsPrivate);
      }
      if (ExpirationTime != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ExpirationTime);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Value);
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
      if (IsPrivate != false) {
        size += 1 + 1;
      }
      if (ExpirationTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ExpirationTime);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Entry other) {
      if (other == null) {
        return;
      }
      if (other.IsPrivate != false) {
        IsPrivate = other.IsPrivate;
      }
      if (other.ExpirationTime != 0UL) {
        ExpirationTime = other.ExpirationTime;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
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
            IsPrivate = input.ReadBool();
            break;
          }
          case 16: {
            ExpirationTime = input.ReadUInt64();
            break;
          }
          case 26: {
            Value = input.ReadBytes();
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
            IsPrivate = input.ReadBool();
            break;
          }
          case 16: {
            ExpirationTime = input.ReadUInt64();
            break;
          }
          case 26: {
            Value = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SpaceIdBucket : pb::IMessage<SpaceIdBucket>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpaceIdBucket> _parser = new pb::MessageParser<SpaceIdBucket>(() => new SpaceIdBucket());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpaceIdBucket> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.ConnectSecureStorage.ConnectSecureStorageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceIdBucket() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceIdBucket(SpaceIdBucket other) : this() {
      elements_ = other.elements_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceIdBucket Clone() {
      return new SpaceIdBucket(this);
    }

    /// <summary>Field number for the "elements" field.</summary>
    public const int ElementsFieldNumber = 1;
    private static readonly pbc::MapField<string, global::Uplay.ConnectSecureStorage.Entry>.Codec _map_elements_codec
        = new pbc::MapField<string, global::Uplay.ConnectSecureStorage.Entry>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Uplay.ConnectSecureStorage.Entry.Parser), 10);
    private readonly pbc::MapField<string, global::Uplay.ConnectSecureStorage.Entry> elements_ = new pbc::MapField<string, global::Uplay.ConnectSecureStorage.Entry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Uplay.ConnectSecureStorage.Entry> Elements {
      get { return elements_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpaceIdBucket);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpaceIdBucket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Elements.Equals(other.Elements)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Elements.GetHashCode();
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
      elements_.WriteTo(output, _map_elements_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      elements_.WriteTo(ref output, _map_elements_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += elements_.CalculateSize(_map_elements_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpaceIdBucket other) {
      if (other == null) {
        return;
      }
      elements_.Add(other.elements_);
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
            elements_.AddEntriesFrom(input, _map_elements_codec);
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
            elements_.AddEntriesFrom(ref input, _map_elements_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SecureStorage : pb::IMessage<SecureStorage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SecureStorage> _parser = new pb::MessageParser<SecureStorage>(() => new SecureStorage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SecureStorage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.ConnectSecureStorage.ConnectSecureStorageReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SecureStorage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SecureStorage(SecureStorage other) : this() {
      data_ = other.data_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SecureStorage Clone() {
      return new SecureStorage(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private static readonly pbc::MapField<string, global::Uplay.ConnectSecureStorage.SpaceIdBucket>.Codec _map_data_codec
        = new pbc::MapField<string, global::Uplay.ConnectSecureStorage.SpaceIdBucket>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Uplay.ConnectSecureStorage.SpaceIdBucket.Parser), 10);
    private readonly pbc::MapField<string, global::Uplay.ConnectSecureStorage.SpaceIdBucket> data_ = new pbc::MapField<string, global::Uplay.ConnectSecureStorage.SpaceIdBucket>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Uplay.ConnectSecureStorage.SpaceIdBucket> Data {
      get { return data_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SecureStorage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SecureStorage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Data.Equals(other.Data)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Data.GetHashCode();
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
      data_.WriteTo(output, _map_data_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      data_.WriteTo(ref output, _map_data_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += data_.CalculateSize(_map_data_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SecureStorage other) {
      if (other == null) {
        return;
      }
      data_.Add(other.data_);
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
            data_.AddEntriesFrom(input, _map_data_codec);
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
            data_.AddEntriesFrom(ref input, _map_data_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Cache : pb::IMessage<Cache>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Cache> _parser = new pb::MessageParser<Cache>(() => new Cache());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Cache> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.ConnectSecureStorage.ConnectSecureStorageReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Cache() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Cache(Cache other) : this() {
      switch (other.ProdCase) {
        case ProdOneofCase.Prod:
          Prod = other.Prod.Clone();
          break;
      }

      switch (other.UatCase) {
        case UatOneofCase.Uat:
          Uat = other.Uat.Clone();
          break;
      }

      switch (other.DevCase) {
        case DevOneofCase.Dev:
          Dev = other.Dev.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Cache Clone() {
      return new Cache(this);
    }

    /// <summary>Field number for the "prod" field.</summary>
    public const int ProdFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Uplay.ConnectSecureStorage.SecureStorage Prod {
      get { return ProdCase_ == ProdOneofCase.Prod ? (global::Uplay.ConnectSecureStorage.SecureStorage) Prod_ : null; }
      set {
        Prod_ = value;
        ProdCase_ = value == null ? ProdOneofCase.None : ProdOneofCase.Prod;
      }
    }

    /// <summary>Field number for the "uat" field.</summary>
    public const int UatFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Uplay.ConnectSecureStorage.SecureStorage Uat {
      get { return UatCase_ == UatOneofCase.Uat ? (global::Uplay.ConnectSecureStorage.SecureStorage) Uat_ : null; }
      set {
        Uat_ = value;
        UatCase_ = value == null ? UatOneofCase.None : UatOneofCase.Uat;
      }
    }

    /// <summary>Field number for the "dev" field.</summary>
    public const int DevFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Uplay.ConnectSecureStorage.SecureStorage Dev {
      get { return DevCase_ == DevOneofCase.Dev ? (global::Uplay.ConnectSecureStorage.SecureStorage) Dev_ : null; }
      set {
        Dev_ = value;
        DevCase_ = value == null ? DevOneofCase.None : DevOneofCase.Dev;
      }
    }

    private object Prod_;
    /// <summary>Enum of possible cases for the "_prod" oneof.</summary>
    public enum ProdOneofCase {
      None = 0,
      Prod = 1,
    }
    private ProdOneofCase ProdCase_ = ProdOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProdOneofCase ProdCase {
      get { return ProdCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearProd() {
      ProdCase_ = ProdOneofCase.None;
      Prod_ = null;
    }

    private object Uat_;
    /// <summary>Enum of possible cases for the "_uat" oneof.</summary>
    public enum UatOneofCase {
      None = 0,
      Uat = 2,
    }
    private UatOneofCase UatCase_ = UatOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UatOneofCase UatCase {
      get { return UatCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearUat() {
      UatCase_ = UatOneofCase.None;
      Uat_ = null;
    }

    private object Dev_;
    /// <summary>Enum of possible cases for the "_dev" oneof.</summary>
    public enum DevOneofCase {
      None = 0,
      Dev = 3,
    }
    private DevOneofCase DevCase_ = DevOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DevOneofCase DevCase {
      get { return DevCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDev() {
      DevCase_ = DevOneofCase.None;
      Dev_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Cache);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Cache other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Prod, other.Prod)) return false;
      if (!object.Equals(Uat, other.Uat)) return false;
      if (!object.Equals(Dev, other.Dev)) return false;
      if (ProdCase != other.ProdCase) return false;
      if (UatCase != other.UatCase) return false;
      if (DevCase != other.DevCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ProdCase_ == ProdOneofCase.Prod) hash ^= Prod.GetHashCode();
      if (UatCase_ == UatOneofCase.Uat) hash ^= Uat.GetHashCode();
      if (DevCase_ == DevOneofCase.Dev) hash ^= Dev.GetHashCode();
      hash ^= (int) ProdCase_;
      hash ^= (int) UatCase_;
      hash ^= (int) DevCase_;
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
      if (ProdCase_ == ProdOneofCase.Prod) {
        output.WriteRawTag(10);
        output.WriteMessage(Prod);
      }
      if (UatCase_ == UatOneofCase.Uat) {
        output.WriteRawTag(18);
        output.WriteMessage(Uat);
      }
      if (DevCase_ == DevOneofCase.Dev) {
        output.WriteRawTag(26);
        output.WriteMessage(Dev);
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
      if (ProdCase_ == ProdOneofCase.Prod) {
        output.WriteRawTag(10);
        output.WriteMessage(Prod);
      }
      if (UatCase_ == UatOneofCase.Uat) {
        output.WriteRawTag(18);
        output.WriteMessage(Uat);
      }
      if (DevCase_ == DevOneofCase.Dev) {
        output.WriteRawTag(26);
        output.WriteMessage(Dev);
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
      if (ProdCase_ == ProdOneofCase.Prod) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Prod);
      }
      if (UatCase_ == UatOneofCase.Uat) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Uat);
      }
      if (DevCase_ == DevOneofCase.Dev) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Dev);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Cache other) {
      if (other == null) {
        return;
      }
      switch (other.ProdCase) {
        case ProdOneofCase.Prod:
          if (Prod == null) {
            Prod = new global::Uplay.ConnectSecureStorage.SecureStorage();
          }
          Prod.MergeFrom(other.Prod);
          break;
      }

      switch (other.UatCase) {
        case UatOneofCase.Uat:
          if (Uat == null) {
            Uat = new global::Uplay.ConnectSecureStorage.SecureStorage();
          }
          Uat.MergeFrom(other.Uat);
          break;
      }

      switch (other.DevCase) {
        case DevOneofCase.Dev:
          if (Dev == null) {
            Dev = new global::Uplay.ConnectSecureStorage.SecureStorage();
          }
          Dev.MergeFrom(other.Dev);
          break;
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
          case 10: {
            global::Uplay.ConnectSecureStorage.SecureStorage subBuilder = new global::Uplay.ConnectSecureStorage.SecureStorage();
            if (ProdCase_ == ProdOneofCase.Prod) {
              subBuilder.MergeFrom(Prod);
            }
            input.ReadMessage(subBuilder);
            Prod = subBuilder;
            break;
          }
          case 18: {
            global::Uplay.ConnectSecureStorage.SecureStorage subBuilder = new global::Uplay.ConnectSecureStorage.SecureStorage();
            if (UatCase_ == UatOneofCase.Uat) {
              subBuilder.MergeFrom(Uat);
            }
            input.ReadMessage(subBuilder);
            Uat = subBuilder;
            break;
          }
          case 26: {
            global::Uplay.ConnectSecureStorage.SecureStorage subBuilder = new global::Uplay.ConnectSecureStorage.SecureStorage();
            if (DevCase_ == DevOneofCase.Dev) {
              subBuilder.MergeFrom(Dev);
            }
            input.ReadMessage(subBuilder);
            Dev = subBuilder;
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
            global::Uplay.ConnectSecureStorage.SecureStorage subBuilder = new global::Uplay.ConnectSecureStorage.SecureStorage();
            if (ProdCase_ == ProdOneofCase.Prod) {
              subBuilder.MergeFrom(Prod);
            }
            input.ReadMessage(subBuilder);
            Prod = subBuilder;
            break;
          }
          case 18: {
            global::Uplay.ConnectSecureStorage.SecureStorage subBuilder = new global::Uplay.ConnectSecureStorage.SecureStorage();
            if (UatCase_ == UatOneofCase.Uat) {
              subBuilder.MergeFrom(Uat);
            }
            input.ReadMessage(subBuilder);
            Uat = subBuilder;
            break;
          }
          case 26: {
            global::Uplay.ConnectSecureStorage.SecureStorage subBuilder = new global::Uplay.ConnectSecureStorage.SecureStorage();
            if (DevCase_ == DevOneofCase.Dev) {
              subBuilder.MergeFrom(Dev);
            }
            input.ReadMessage(subBuilder);
            Dev = subBuilder;
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
