// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: hapi/chart/chart.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Hapi.Chart {

  /// <summary>Holder for reflection information generated from hapi/chart/chart.proto</summary>
  public static partial class ChartReflection {

    #region Descriptor
    /// <summary>File descriptor for hapi/chart/chart.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChartReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZoYXBpL2NoYXJ0L2NoYXJ0LnByb3RvEgpoYXBpLmNoYXJ0GhdoYXBpL2No",
            "YXJ0L2NvbmZpZy5wcm90bxoZaGFwaS9jaGFydC9tZXRhZGF0YS5wcm90bxoZ",
            "aGFwaS9jaGFydC90ZW1wbGF0ZS5wcm90bxoZZ29vZ2xlL3Byb3RvYnVmL2Fu",
            "eS5wcm90byLKAQoFQ2hhcnQSJgoIbWV0YWRhdGEYASABKAsyFC5oYXBpLmNo",
            "YXJ0Lk1ldGFkYXRhEicKCXRlbXBsYXRlcxgCIAMoCzIULmhhcGkuY2hhcnQu",
            "VGVtcGxhdGUSJwoMZGVwZW5kZW5jaWVzGAMgAygLMhEuaGFwaS5jaGFydC5D",
            "aGFydBIiCgZ2YWx1ZXMYBCABKAsyEi5oYXBpLmNoYXJ0LkNvbmZpZxIjCgVm",
            "aWxlcxgFIAMoCzIULmdvb2dsZS5wcm90b2J1Zi5BbnlCB1oFY2hhcnRiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Hapi.Chart.ConfigReflection.Descriptor, global::Hapi.Chart.MetadataReflection.Descriptor, global::Hapi.Chart.TemplateReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Hapi.Chart.Chart), global::Hapi.Chart.Chart.Parser, new[]{ "Metadata", "Templates", "Dependencies", "Values", "Files" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///	Chart is a helm package that contains metadata, a default config, zero or more
  ///	optionally parameterizable templates, and zero or more charts (dependencies).
  /// </summary>
  public sealed partial class Chart : pb::IMessage<Chart> {
    private static readonly pb::MessageParser<Chart> _parser = new pb::MessageParser<Chart>(() => new Chart());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Chart> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Hapi.Chart.ChartReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Chart() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Chart(Chart other) : this() {
      Metadata = other.metadata_ != null ? other.Metadata.Clone() : null;
      templates_ = other.templates_.Clone();
      dependencies_ = other.dependencies_.Clone();
      Values = other.values_ != null ? other.Values.Clone() : null;
      files_ = other.files_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Chart Clone() {
      return new Chart(this);
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 1;
    private global::Hapi.Chart.Metadata metadata_;
    /// <summary>
    /// Contents of the Chartfile.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Hapi.Chart.Metadata Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "templates" field.</summary>
    public const int TemplatesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Hapi.Chart.Template> _repeated_templates_codec
        = pb::FieldCodec.ForMessage(18, global::Hapi.Chart.Template.Parser);
    private readonly pbc::RepeatedField<global::Hapi.Chart.Template> templates_ = new pbc::RepeatedField<global::Hapi.Chart.Template>();
    /// <summary>
    /// Templates for this chart.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Hapi.Chart.Template> Templates {
      get { return templates_; }
    }

    /// <summary>Field number for the "dependencies" field.</summary>
    public const int DependenciesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Hapi.Chart.Chart> _repeated_dependencies_codec
        = pb::FieldCodec.ForMessage(26, global::Hapi.Chart.Chart.Parser);
    private readonly pbc::RepeatedField<global::Hapi.Chart.Chart> dependencies_ = new pbc::RepeatedField<global::Hapi.Chart.Chart>();
    /// <summary>
    /// Charts that this chart depends on.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Hapi.Chart.Chart> Dependencies {
      get { return dependencies_; }
    }

    /// <summary>Field number for the "values" field.</summary>
    public const int ValuesFieldNumber = 4;
    private global::Hapi.Chart.Config values_;
    /// <summary>
    /// Default config for this template.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Hapi.Chart.Config Values {
      get { return values_; }
      set {
        values_ = value;
      }
    }

    /// <summary>Field number for the "files" field.</summary>
    public const int FilesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Any> _repeated_files_codec
        = pb::FieldCodec.ForMessage(42, global::Google.Protobuf.WellKnownTypes.Any.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> files_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any>();
    /// <summary>
    /// Miscellaneous files in a chart archive,
    /// e.g. README, LICENSE, etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> Files {
      get { return files_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Chart);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Chart other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if(!templates_.Equals(other.templates_)) return false;
      if(!dependencies_.Equals(other.dependencies_)) return false;
      if (!object.Equals(Values, other.Values)) return false;
      if(!files_.Equals(other.files_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      hash ^= templates_.GetHashCode();
      hash ^= dependencies_.GetHashCode();
      if (values_ != null) hash ^= Values.GetHashCode();
      hash ^= files_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (metadata_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Metadata);
      }
      templates_.WriteTo(output, _repeated_templates_codec);
      dependencies_.WriteTo(output, _repeated_dependencies_codec);
      if (values_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Values);
      }
      files_.WriteTo(output, _repeated_files_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      size += templates_.CalculateSize(_repeated_templates_codec);
      size += dependencies_.CalculateSize(_repeated_dependencies_codec);
      if (values_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Values);
      }
      size += files_.CalculateSize(_repeated_files_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Chart other) {
      if (other == null) {
        return;
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          metadata_ = new global::Hapi.Chart.Metadata();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      templates_.Add(other.templates_);
      dependencies_.Add(other.dependencies_);
      if (other.values_ != null) {
        if (values_ == null) {
          values_ = new global::Hapi.Chart.Config();
        }
        Values.MergeFrom(other.Values);
      }
      files_.Add(other.files_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (metadata_ == null) {
              metadata_ = new global::Hapi.Chart.Metadata();
            }
            input.ReadMessage(metadata_);
            break;
          }
          case 18: {
            templates_.AddEntriesFrom(input, _repeated_templates_codec);
            break;
          }
          case 26: {
            dependencies_.AddEntriesFrom(input, _repeated_dependencies_codec);
            break;
          }
          case 34: {
            if (values_ == null) {
              values_ = new global::Hapi.Chart.Config();
            }
            input.ReadMessage(values_);
            break;
          }
          case 42: {
            files_.AddEntriesFrom(input, _repeated_files_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
