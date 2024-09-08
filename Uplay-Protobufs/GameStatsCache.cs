// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: game_stats_cache.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Uplay.GameStatsCache {

  /// <summary>Holder for reflection information generated from game_stats_cache.proto</summary>
  public static partial class GameStatsCacheReflection {

    #region Descriptor
    /// <summary>File descriptor for game_stats_cache.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameStatsCacheReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chx1cGxheS9nYW1lX3N0YXRzX2NhY2hlLnByb3RvEhxtZy5wcm90b2NvbC5n",
            "YW1lX3N0YXRzX2NhY2hlIi8KDUdhbWVTdGF0c0NhcmQSEAoIc3BhY2VfaWQY",
            "ASABKAkSDAoEanNvbhgCIAEoCSK2AQoOR2FtZVN0YXRzQ2FjaGUSDwoHdmVy",
            "c2lvbhgBIAIoDRJHChJwbGF5ZXJfc3RhdHNfY2FyZHMYAiADKAsyKy5tZy5w",
            "cm90b2NvbC5nYW1lX3N0YXRzX2NhY2hlLkdhbWVTdGF0c0NhcmQSSgoVY29t",
            "bXVuaXR5X3N0YXRzX2NhcmRzGAMgAygLMisubWcucHJvdG9jb2wuZ2FtZV9z",
            "dGF0c19jYWNoZS5HYW1lU3RhdHNDYXJk"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.GameStatsCache.GameStatsCard), global::Uplay.GameStatsCache.GameStatsCard.Parser, new[]{ "SpaceId", "Json" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.GameStatsCache.GameStatsCache), global::Uplay.GameStatsCache.GameStatsCache.Parser, new[]{ "Version", "PlayerStatsCards", "CommunityStatsCards" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GameStatsCard : pb::IMessage<GameStatsCard>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GameStatsCard> _parser = new pb::MessageParser<GameStatsCard>(() => new GameStatsCard());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GameStatsCard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.GameStatsCache.GameStatsCacheReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameStatsCard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameStatsCard(GameStatsCard other) : this() {
      spaceId_ = other.spaceId_;
      json_ = other.json_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameStatsCard Clone() {
      return new GameStatsCard(this);
    }

    /// <summary>Field number for the "space_id" field.</summary>
    public const int SpaceIdFieldNumber = 1;
    private readonly static string SpaceIdDefaultValue = "";

    private string spaceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SpaceId {
      get { return spaceId_ ?? SpaceIdDefaultValue; }
      set {
        spaceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "space_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSpaceId {
      get { return spaceId_ != null; }
    }
    /// <summary>Clears the value of the "space_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSpaceId() {
      spaceId_ = null;
    }

    /// <summary>Field number for the "json" field.</summary>
    public const int JsonFieldNumber = 2;
    private readonly static string JsonDefaultValue = "";

    private string json_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Json {
      get { return json_ ?? JsonDefaultValue; }
      set {
        json_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "json" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasJson {
      get { return json_ != null; }
    }
    /// <summary>Clears the value of the "json" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearJson() {
      json_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GameStatsCard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GameStatsCard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SpaceId != other.SpaceId) return false;
      if (Json != other.Json) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasSpaceId) hash ^= SpaceId.GetHashCode();
      if (HasJson) hash ^= Json.GetHashCode();
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
      if (HasSpaceId) {
        output.WriteRawTag(10);
        output.WriteString(SpaceId);
      }
      if (HasJson) {
        output.WriteRawTag(18);
        output.WriteString(Json);
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
      if (HasSpaceId) {
        output.WriteRawTag(10);
        output.WriteString(SpaceId);
      }
      if (HasJson) {
        output.WriteRawTag(18);
        output.WriteString(Json);
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
      if (HasSpaceId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpaceId);
      }
      if (HasJson) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Json);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GameStatsCard other) {
      if (other == null) {
        return;
      }
      if (other.HasSpaceId) {
        SpaceId = other.SpaceId;
      }
      if (other.HasJson) {
        Json = other.Json;
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
            SpaceId = input.ReadString();
            break;
          }
          case 18: {
            Json = input.ReadString();
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
            SpaceId = input.ReadString();
            break;
          }
          case 18: {
            Json = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GameStatsCache : pb::IMessage<GameStatsCache>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GameStatsCache> _parser = new pb::MessageParser<GameStatsCache>(() => new GameStatsCache());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GameStatsCache> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.GameStatsCache.GameStatsCacheReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameStatsCache() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameStatsCache(GameStatsCache other) : this() {
      _hasBits0 = other._hasBits0;
      version_ = other.version_;
      playerStatsCards_ = other.playerStatsCards_.Clone();
      communityStatsCards_ = other.communityStatsCards_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameStatsCache Clone() {
      return new GameStatsCache(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private readonly static uint VersionDefaultValue = 0;

    private uint version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Version {
      get { if ((_hasBits0 & 1) != 0) { return version_; } else { return VersionDefaultValue; } }
      set {
        _hasBits0 |= 1;
        version_ = value;
      }
    }
    /// <summary>Gets whether the "version" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasVersion {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "version" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearVersion() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "player_stats_cards" field.</summary>
    public const int PlayerStatsCardsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Uplay.GameStatsCache.GameStatsCard> _repeated_playerStatsCards_codec
        = pb::FieldCodec.ForMessage(18, global::Uplay.GameStatsCache.GameStatsCard.Parser);
    private readonly pbc::RepeatedField<global::Uplay.GameStatsCache.GameStatsCard> playerStatsCards_ = new pbc::RepeatedField<global::Uplay.GameStatsCache.GameStatsCard>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Uplay.GameStatsCache.GameStatsCard> PlayerStatsCards {
      get { return playerStatsCards_; }
    }

    /// <summary>Field number for the "community_stats_cards" field.</summary>
    public const int CommunityStatsCardsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Uplay.GameStatsCache.GameStatsCard> _repeated_communityStatsCards_codec
        = pb::FieldCodec.ForMessage(26, global::Uplay.GameStatsCache.GameStatsCard.Parser);
    private readonly pbc::RepeatedField<global::Uplay.GameStatsCache.GameStatsCard> communityStatsCards_ = new pbc::RepeatedField<global::Uplay.GameStatsCache.GameStatsCard>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Uplay.GameStatsCache.GameStatsCard> CommunityStatsCards {
      get { return communityStatsCards_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GameStatsCache);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GameStatsCache other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if(!playerStatsCards_.Equals(other.playerStatsCards_)) return false;
      if(!communityStatsCards_.Equals(other.communityStatsCards_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasVersion) hash ^= Version.GetHashCode();
      hash ^= playerStatsCards_.GetHashCode();
      hash ^= communityStatsCards_.GetHashCode();
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
      if (HasVersion) {
        output.WriteRawTag(8);
        output.WriteUInt32(Version);
      }
      playerStatsCards_.WriteTo(output, _repeated_playerStatsCards_codec);
      communityStatsCards_.WriteTo(output, _repeated_communityStatsCards_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasVersion) {
        output.WriteRawTag(8);
        output.WriteUInt32(Version);
      }
      playerStatsCards_.WriteTo(ref output, _repeated_playerStatsCards_codec);
      communityStatsCards_.WriteTo(ref output, _repeated_communityStatsCards_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasVersion) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Version);
      }
      size += playerStatsCards_.CalculateSize(_repeated_playerStatsCards_codec);
      size += communityStatsCards_.CalculateSize(_repeated_communityStatsCards_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GameStatsCache other) {
      if (other == null) {
        return;
      }
      if (other.HasVersion) {
        Version = other.Version;
      }
      playerStatsCards_.Add(other.playerStatsCards_);
      communityStatsCards_.Add(other.communityStatsCards_);
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
            playerStatsCards_.AddEntriesFrom(input, _repeated_playerStatsCards_codec);
            break;
          }
          case 26: {
            communityStatsCards_.AddEntriesFrom(input, _repeated_communityStatsCards_codec);
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
            playerStatsCards_.AddEntriesFrom(ref input, _repeated_playerStatsCards_codec);
            break;
          }
          case 26: {
            communityStatsCards_.AddEntriesFrom(ref input, _repeated_communityStatsCards_codec);
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
