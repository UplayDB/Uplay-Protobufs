// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: remember_device_file.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Uplay.RememberDeviceFile {

  /// <summary>Holder for reflection information generated from remember_device_file.proto</summary>
  public static partial class RememberDeviceFileReflection {

    #region Descriptor
    /// <summary>File descriptor for remember_device_file.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RememberDeviceFileReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiB1cGxheS9yZW1lbWJlcl9kZXZpY2VfZmlsZS5wcm90bxIgbWcucHJvdG9j",
            "b2wucmVtZW1iZXJfZGV2aWNlX2ZpbGUicwoEVXNlchIUCgphY2NvdW50X2lk",
            "GAEgASgJSAASFAoKZW1haWxfaGFzaBgCIAEoCUgBEhMKCXJkX3RpY2tldBgD",
            "IAEoCUgCQg0KC19hY2NvdW50X2lkQg0KC19lbWFpbF9oYXNoQgwKCl9yZF90",
            "aWNrZXQiZgoOVXNlckxvZ2luQ2FjaGUSNQoFdXNlcnMYAiADKAsyJi5tZy5w",
            "cm90b2NvbC5yZW1lbWJlcl9kZXZpY2VfZmlsZS5Vc2VyEhEKB3ZlcnNpb24Y",
            "ASABKA1IAEIKCghfdmVyc2lvbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.RememberDeviceFile.User), global::Uplay.RememberDeviceFile.User.Parser, new[]{ "AccountId", "EmailHash", "RdTicket" }, new[]{ "AccountId", "EmailHash", "RdTicket" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.RememberDeviceFile.UserLoginCache), global::Uplay.RememberDeviceFile.UserLoginCache.Parser, new[]{ "Users", "Version" }, new[]{ "Version" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class User : pb::IMessage<User>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.RememberDeviceFile.RememberDeviceFileReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public User(User other) : this() {
      switch (other.AccountIdCase) {
        case AccountIdOneofCase.AccountId:
          AccountId = other.AccountId;
          break;
      }

      switch (other.EmailHashCase) {
        case EmailHashOneofCase.EmailHash:
          EmailHash = other.EmailHash;
          break;
      }

      switch (other.RdTicketCase) {
        case RdTicketOneofCase.RdTicket:
          RdTicket = other.RdTicket;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public User Clone() {
      return new User(this);
    }

    /// <summary>Field number for the "account_id" field.</summary>
    public const int AccountIdFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccountId {
      get { return AccountIdCase_ == AccountIdOneofCase.AccountId ? (string) AccountId_ : ""; }
      set {
        AccountId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        AccountIdCase_ = AccountIdOneofCase.AccountId;
      }
    }

    /// <summary>Field number for the "email_hash" field.</summary>
    public const int EmailHashFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EmailHash {
      get { return EmailHashCase_ == EmailHashOneofCase.EmailHash ? (string) EmailHash_ : ""; }
      set {
        EmailHash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        EmailHashCase_ = EmailHashOneofCase.EmailHash;
      }
    }

    /// <summary>Field number for the "rd_ticket" field.</summary>
    public const int RdTicketFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RdTicket {
      get { return RdTicketCase_ == RdTicketOneofCase.RdTicket ? (string) RdTicket_ : ""; }
      set {
        RdTicket_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        RdTicketCase_ = RdTicketOneofCase.RdTicket;
      }
    }

    private object AccountId_;
    /// <summary>Enum of possible cases for the "_account_id" oneof.</summary>
    public enum AccountIdOneofCase {
      None = 0,
      AccountId = 1,
    }
    private AccountIdOneofCase AccountIdCase_ = AccountIdOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountIdOneofCase AccountIdCase {
      get { return AccountIdCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAccountId() {
      AccountIdCase_ = AccountIdOneofCase.None;
      AccountId_ = null;
    }

    private object EmailHash_;
    /// <summary>Enum of possible cases for the "_email_hash" oneof.</summary>
    public enum EmailHashOneofCase {
      None = 0,
      EmailHash = 2,
    }
    private EmailHashOneofCase EmailHashCase_ = EmailHashOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EmailHashOneofCase EmailHashCase {
      get { return EmailHashCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEmailHash() {
      EmailHashCase_ = EmailHashOneofCase.None;
      EmailHash_ = null;
    }

    private object RdTicket_;
    /// <summary>Enum of possible cases for the "_rd_ticket" oneof.</summary>
    public enum RdTicketOneofCase {
      None = 0,
      RdTicket = 3,
    }
    private RdTicketOneofCase RdTicketCase_ = RdTicketOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RdTicketOneofCase RdTicketCase {
      get { return RdTicketCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRdTicket() {
      RdTicketCase_ = RdTicketOneofCase.None;
      RdTicket_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccountId != other.AccountId) return false;
      if (EmailHash != other.EmailHash) return false;
      if (RdTicket != other.RdTicket) return false;
      if (AccountIdCase != other.AccountIdCase) return false;
      if (EmailHashCase != other.EmailHashCase) return false;
      if (RdTicketCase != other.RdTicketCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AccountIdCase_ == AccountIdOneofCase.AccountId) hash ^= AccountId.GetHashCode();
      if (EmailHashCase_ == EmailHashOneofCase.EmailHash) hash ^= EmailHash.GetHashCode();
      if (RdTicketCase_ == RdTicketOneofCase.RdTicket) hash ^= RdTicket.GetHashCode();
      hash ^= (int) AccountIdCase_;
      hash ^= (int) EmailHashCase_;
      hash ^= (int) RdTicketCase_;
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
      if (AccountIdCase_ == AccountIdOneofCase.AccountId) {
        output.WriteRawTag(10);
        output.WriteString(AccountId);
      }
      if (EmailHashCase_ == EmailHashOneofCase.EmailHash) {
        output.WriteRawTag(18);
        output.WriteString(EmailHash);
      }
      if (RdTicketCase_ == RdTicketOneofCase.RdTicket) {
        output.WriteRawTag(26);
        output.WriteString(RdTicket);
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
      if (AccountIdCase_ == AccountIdOneofCase.AccountId) {
        output.WriteRawTag(10);
        output.WriteString(AccountId);
      }
      if (EmailHashCase_ == EmailHashOneofCase.EmailHash) {
        output.WriteRawTag(18);
        output.WriteString(EmailHash);
      }
      if (RdTicketCase_ == RdTicketOneofCase.RdTicket) {
        output.WriteRawTag(26);
        output.WriteString(RdTicket);
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
      if (AccountIdCase_ == AccountIdOneofCase.AccountId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccountId);
      }
      if (EmailHashCase_ == EmailHashOneofCase.EmailHash) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EmailHash);
      }
      if (RdTicketCase_ == RdTicketOneofCase.RdTicket) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RdTicket);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(User other) {
      if (other == null) {
        return;
      }
      switch (other.AccountIdCase) {
        case AccountIdOneofCase.AccountId:
          AccountId = other.AccountId;
          break;
      }

      switch (other.EmailHashCase) {
        case EmailHashOneofCase.EmailHash:
          EmailHash = other.EmailHash;
          break;
      }

      switch (other.RdTicketCase) {
        case RdTicketOneofCase.RdTicket:
          RdTicket = other.RdTicket;
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
            AccountId = input.ReadString();
            break;
          }
          case 18: {
            EmailHash = input.ReadString();
            break;
          }
          case 26: {
            RdTicket = input.ReadString();
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
            AccountId = input.ReadString();
            break;
          }
          case 18: {
            EmailHash = input.ReadString();
            break;
          }
          case 26: {
            RdTicket = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class UserLoginCache : pb::IMessage<UserLoginCache>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserLoginCache> _parser = new pb::MessageParser<UserLoginCache>(() => new UserLoginCache());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserLoginCache> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.RememberDeviceFile.RememberDeviceFileReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserLoginCache() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserLoginCache(UserLoginCache other) : this() {
      users_ = other.users_.Clone();
      switch (other.VersionCase) {
        case VersionOneofCase.Version:
          Version = other.Version;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserLoginCache Clone() {
      return new UserLoginCache(this);
    }

    /// <summary>Field number for the "users" field.</summary>
    public const int UsersFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Uplay.RememberDeviceFile.User> _repeated_users_codec
        = pb::FieldCodec.ForMessage(18, global::Uplay.RememberDeviceFile.User.Parser);
    private readonly pbc::RepeatedField<global::Uplay.RememberDeviceFile.User> users_ = new pbc::RepeatedField<global::Uplay.RememberDeviceFile.User>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Uplay.RememberDeviceFile.User> Users {
      get { return users_; }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Version {
      get { return VersionCase_ == VersionOneofCase.Version ? (uint) Version_ : 0; }
      set {
        Version_ = value;
        VersionCase_ = VersionOneofCase.Version;
      }
    }

    private object Version_;
    /// <summary>Enum of possible cases for the "_version" oneof.</summary>
    public enum VersionOneofCase {
      None = 0,
      Version = 1,
    }
    private VersionOneofCase VersionCase_ = VersionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VersionOneofCase VersionCase {
      get { return VersionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearVersion() {
      VersionCase_ = VersionOneofCase.None;
      Version_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserLoginCache);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserLoginCache other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!users_.Equals(other.users_)) return false;
      if (Version != other.Version) return false;
      if (VersionCase != other.VersionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= users_.GetHashCode();
      if (VersionCase_ == VersionOneofCase.Version) hash ^= Version.GetHashCode();
      hash ^= (int) VersionCase_;
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
      if (VersionCase_ == VersionOneofCase.Version) {
        output.WriteRawTag(8);
        output.WriteUInt32(Version);
      }
      users_.WriteTo(output, _repeated_users_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (VersionCase_ == VersionOneofCase.Version) {
        output.WriteRawTag(8);
        output.WriteUInt32(Version);
      }
      users_.WriteTo(ref output, _repeated_users_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += users_.CalculateSize(_repeated_users_codec);
      if (VersionCase_ == VersionOneofCase.Version) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Version);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UserLoginCache other) {
      if (other == null) {
        return;
      }
      users_.Add(other.users_);
      switch (other.VersionCase) {
        case VersionOneofCase.Version:
          Version = other.Version;
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
          case 8: {
            Version = input.ReadUInt32();
            break;
          }
          case 18: {
            users_.AddEntriesFrom(input, _repeated_users_codec);
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
            Version = input.ReadUInt32();
            break;
          }
          case 18: {
            users_.AddEntriesFrom(ref input, _repeated_users_codec);
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
