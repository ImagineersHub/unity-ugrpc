// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ugrpc_pipe/ugrpc_pipe.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace UGrpc.Pipeline.GrpcPipe.V1 {

  /// <summary>Holder for reflection information generated from ugrpc_pipe/ugrpc_pipe.proto</summary>
  public static partial class UgrpcPipeReflection {

    #region Descriptor
    /// <summary>File descriptor for ugrpc_pipe/ugrpc_pipe.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UgrpcPipeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cht1Z3JwY19waXBlL3VncnBjX3BpcGUucHJvdG8SCnVncnBjX3BpcGUaGWdv",
            "b2dsZS9wcm90b2J1Zi9hbnkucHJvdG8ibAoGU3RhdHVzEisKBGNvZGUYASAB",
            "KA4yHS51Z3JwY19waXBlLlN0YXR1cy5TdGF0dXNDb2RlEg8KB21lc3NhZ2UY",
            "AiABKAkiJAoKU3RhdHVzQ29kZRILCgdTVUNDRVNTEAASCQoFRVJST1IQASLc",
            "AQoPUHJvamVjdEluZm9SZXNwEicKBnN0YXR1cxgBIAEoCzISLnVncnBjX3Bp",
            "cGUuU3RhdHVzSACIAQESOgoIcGxhdGZvcm0YAiABKA4yKC51Z3JwY19waXBl",
            "LlByb2plY3RJbmZvUmVzcC5QbGF0Zm9ybUNvZGUSEAoIZGF0YVBhdGgYAyAB",
            "KAkSEwoLcHJvamVjdFJvb3QYBCABKAkiMgoMUGxhdGZvcm1Db2RlEgsKB3Vu",
            "a25vd24QABIJCgV1bml0eRABEgoKBnVucmVhbBACQgkKB19zdGF0dXMiIwoQ",
            "Q29tbWFuZFBhcnNlclJlcRIPCgdwYXlsb2FkGAEgASgJIlgKC0dlbmVyaWNS",
            "ZXNwEiIKBnN0YXR1cxgBIAEoCzISLnVncnBjX3BpcGUuU3RhdHVzEiUKB3Bh",
            "eWxvYWQYAiABKAsyFC5nb29nbGUucHJvdG9idWYuQW55MlMKCVVHcnBjUGlw",
            "ZRJGCg1Db21tYW5kUGFyc2VyEhwudWdycGNfcGlwZS5Db21tYW5kUGFyc2Vy",
            "UmVxGhcudWdycGNfcGlwZS5HZW5lcmljUmVzcEIdqgIaVUdycGMuUGlwZWxp",
            "bmUuR3JwY1BpcGUuVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::UGrpc.Pipeline.GrpcPipe.V1.Status), global::UGrpc.Pipeline.GrpcPipe.V1.Status.Parser, new[]{ "Code", "Message" }, null, new[]{ typeof(global::UGrpc.Pipeline.GrpcPipe.V1.Status.Types.StatusCode) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp), global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Parser, new[]{ "Status", "Platform", "DataPath", "ProjectRoot" }, new[]{ "Status" }, new[]{ typeof(global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Types.PlatformCode) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UGrpc.Pipeline.GrpcPipe.V1.CommandParserReq), global::UGrpc.Pipeline.GrpcPipe.V1.CommandParserReq.Parser, new[]{ "Payload" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UGrpc.Pipeline.GrpcPipe.V1.GenericResp), global::UGrpc.Pipeline.GrpcPipe.V1.GenericResp.Parser, new[]{ "Status", "Payload" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Status : pb::IMessage<Status>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Status> _parser = new pb::MessageParser<Status>(() => new Status());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Status> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UGrpc.Pipeline.GrpcPipe.V1.UgrpcPipeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Status() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Status(Status other) : this() {
      code_ = other.code_;
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Status Clone() {
      return new Status(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private global::UGrpc.Pipeline.GrpcPipe.V1.Status.Types.StatusCode code_ = global::UGrpc.Pipeline.GrpcPipe.V1.Status.Types.StatusCode.Success;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UGrpc.Pipeline.GrpcPipe.V1.Status.Types.StatusCode Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Status);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Status other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != global::UGrpc.Pipeline.GrpcPipe.V1.Status.Types.StatusCode.Success) hash ^= Code.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
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
      if (Code != global::UGrpc.Pipeline.GrpcPipe.V1.Status.Types.StatusCode.Success) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
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
      if (Code != global::UGrpc.Pipeline.GrpcPipe.V1.Status.Types.StatusCode.Success) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
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
      if (Code != global::UGrpc.Pipeline.GrpcPipe.V1.Status.Types.StatusCode.Success) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Status other) {
      if (other == null) {
        return;
      }
      if (other.Code != global::UGrpc.Pipeline.GrpcPipe.V1.Status.Types.StatusCode.Success) {
        Code = other.Code;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
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
            Code = (global::UGrpc.Pipeline.GrpcPipe.V1.Status.Types.StatusCode) input.ReadEnum();
            break;
          }
          case 18: {
            Message = input.ReadString();
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
            Code = (global::UGrpc.Pipeline.GrpcPipe.V1.Status.Types.StatusCode) input.ReadEnum();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Status message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum StatusCode {
        [pbr::OriginalName("SUCCESS")] Success = 0,
        [pbr::OriginalName("ERROR")] Error = 1,
      }

    }
    #endregion

  }

  public sealed partial class ProjectInfoResp : pb::IMessage<ProjectInfoResp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProjectInfoResp> _parser = new pb::MessageParser<ProjectInfoResp>(() => new ProjectInfoResp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProjectInfoResp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UGrpc.Pipeline.GrpcPipe.V1.UgrpcPipeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectInfoResp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectInfoResp(ProjectInfoResp other) : this() {
      status_ = other.status_ != null ? other.status_.Clone() : null;
      platform_ = other.platform_;
      dataPath_ = other.dataPath_;
      projectRoot_ = other.projectRoot_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectInfoResp Clone() {
      return new ProjectInfoResp(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::UGrpc.Pipeline.GrpcPipe.V1.Status status_;
    /// <summary>
    /// represent the return status
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UGrpc.Pipeline.GrpcPipe.V1.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 2;
    private global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Types.PlatformCode platform_ = global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Types.PlatformCode.Unknown;
    /// <summary>
    /// represent the flatform code
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Types.PlatformCode Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "dataPath" field.</summary>
    public const int DataPathFieldNumber = 3;
    private string dataPath_ = "";
    /// <summary>
    /// represent the path of content assets
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DataPath {
      get { return dataPath_; }
      set {
        dataPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "projectRoot" field.</summary>
    public const int ProjectRootFieldNumber = 4;
    private string projectRoot_ = "";
    /// <summary>
    /// represent the project root path
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProjectRoot {
      get { return projectRoot_; }
      set {
        projectRoot_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProjectInfoResp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProjectInfoResp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Status, other.Status)) return false;
      if (Platform != other.Platform) return false;
      if (DataPath != other.DataPath) return false;
      if (ProjectRoot != other.ProjectRoot) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (status_ != null) hash ^= Status.GetHashCode();
      if (Platform != global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Types.PlatformCode.Unknown) hash ^= Platform.GetHashCode();
      if (DataPath.Length != 0) hash ^= DataPath.GetHashCode();
      if (ProjectRoot.Length != 0) hash ^= ProjectRoot.GetHashCode();
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
      if (status_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Status);
      }
      if (Platform != global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Types.PlatformCode.Unknown) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Platform);
      }
      if (DataPath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DataPath);
      }
      if (ProjectRoot.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ProjectRoot);
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
      if (status_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Status);
      }
      if (Platform != global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Types.PlatformCode.Unknown) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Platform);
      }
      if (DataPath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DataPath);
      }
      if (ProjectRoot.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ProjectRoot);
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
      if (status_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Status);
      }
      if (Platform != global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Types.PlatformCode.Unknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      if (DataPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DataPath);
      }
      if (ProjectRoot.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProjectRoot);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProjectInfoResp other) {
      if (other == null) {
        return;
      }
      if (other.status_ != null) {
        if (status_ == null) {
          Status = new global::UGrpc.Pipeline.GrpcPipe.V1.Status();
        }
        Status.MergeFrom(other.Status);
      }
      if (other.Platform != global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Types.PlatformCode.Unknown) {
        Platform = other.Platform;
      }
      if (other.DataPath.Length != 0) {
        DataPath = other.DataPath;
      }
      if (other.ProjectRoot.Length != 0) {
        ProjectRoot = other.ProjectRoot;
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
            if (status_ == null) {
              Status = new global::UGrpc.Pipeline.GrpcPipe.V1.Status();
            }
            input.ReadMessage(Status);
            break;
          }
          case 16: {
            Platform = (global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Types.PlatformCode) input.ReadEnum();
            break;
          }
          case 26: {
            DataPath = input.ReadString();
            break;
          }
          case 34: {
            ProjectRoot = input.ReadString();
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
            if (status_ == null) {
              Status = new global::UGrpc.Pipeline.GrpcPipe.V1.Status();
            }
            input.ReadMessage(Status);
            break;
          }
          case 16: {
            Platform = (global::UGrpc.Pipeline.GrpcPipe.V1.ProjectInfoResp.Types.PlatformCode) input.ReadEnum();
            break;
          }
          case 26: {
            DataPath = input.ReadString();
            break;
          }
          case 34: {
            ProjectRoot = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ProjectInfoResp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum PlatformCode {
        [pbr::OriginalName("unknown")] Unknown = 0,
        [pbr::OriginalName("unity")] Unity = 1,
        [pbr::OriginalName("unreal")] Unreal = 2,
      }

    }
    #endregion

  }

  public sealed partial class CommandParserReq : pb::IMessage<CommandParserReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CommandParserReq> _parser = new pb::MessageParser<CommandParserReq>(() => new CommandParserReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CommandParserReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UGrpc.Pipeline.GrpcPipe.V1.UgrpcPipeReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommandParserReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommandParserReq(CommandParserReq other) : this() {
      payload_ = other.payload_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommandParserReq Clone() {
      return new CommandParserReq(this);
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 1;
    private string payload_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Payload {
      get { return payload_; }
      set {
        payload_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CommandParserReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CommandParserReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Payload != other.Payload) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Payload.Length != 0) hash ^= Payload.GetHashCode();
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
      if (Payload.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Payload);
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
      if (Payload.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Payload);
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
      if (Payload.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Payload);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CommandParserReq other) {
      if (other == null) {
        return;
      }
      if (other.Payload.Length != 0) {
        Payload = other.Payload;
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
            Payload = input.ReadString();
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
            Payload = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GenericResp : pb::IMessage<GenericResp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GenericResp> _parser = new pb::MessageParser<GenericResp>(() => new GenericResp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GenericResp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UGrpc.Pipeline.GrpcPipe.V1.UgrpcPipeReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenericResp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenericResp(GenericResp other) : this() {
      status_ = other.status_ != null ? other.status_.Clone() : null;
      payload_ = other.payload_ != null ? other.payload_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenericResp Clone() {
      return new GenericResp(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::UGrpc.Pipeline.GrpcPipe.V1.Status status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UGrpc.Pipeline.GrpcPipe.V1.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Any payload_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Any Payload {
      get { return payload_; }
      set {
        payload_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GenericResp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GenericResp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Status, other.Status)) return false;
      if (!object.Equals(Payload, other.Payload)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (status_ != null) hash ^= Status.GetHashCode();
      if (payload_ != null) hash ^= Payload.GetHashCode();
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
      if (status_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Status);
      }
      if (payload_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Payload);
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
      if (status_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Status);
      }
      if (payload_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Payload);
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
      if (status_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Status);
      }
      if (payload_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Payload);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GenericResp other) {
      if (other == null) {
        return;
      }
      if (other.status_ != null) {
        if (status_ == null) {
          Status = new global::UGrpc.Pipeline.GrpcPipe.V1.Status();
        }
        Status.MergeFrom(other.Status);
      }
      if (other.payload_ != null) {
        if (payload_ == null) {
          Payload = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Payload.MergeFrom(other.Payload);
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
            if (status_ == null) {
              Status = new global::UGrpc.Pipeline.GrpcPipe.V1.Status();
            }
            input.ReadMessage(Status);
            break;
          }
          case 18: {
            if (payload_ == null) {
              Payload = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Payload);
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
            if (status_ == null) {
              Status = new global::UGrpc.Pipeline.GrpcPipe.V1.Status();
            }
            input.ReadMessage(Status);
            break;
          }
          case 18: {
            if (payload_ == null) {
              Payload = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Payload);
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
