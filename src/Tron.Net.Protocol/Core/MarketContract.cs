// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tronprotocol/core/contract/market_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protocol {

  /// <summary>Holder for reflection information generated from tronprotocol/core/contract/market_contract.proto</summary>
  public static partial class MarketContractReflection {

    #region Descriptor
    /// <summary>File descriptor for tronprotocol/core/contract/market_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MarketContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjB0cm9ucHJvdG9jb2wvY29yZS9jb250cmFjdC9tYXJrZXRfY29udHJhY3Qu",
            "cHJvdG8SCHByb3RvY29sIpYBChdNYXJrZXRTZWxsQXNzZXRDb250cmFjdBIV",
            "Cg1vd25lcl9hZGRyZXNzGAEgASgMEhUKDXNlbGxfdG9rZW5faWQYAiABKAwS",
            "GwoTc2VsbF90b2tlbl9xdWFudGl0eRgDIAEoAxIUCgxidXlfdG9rZW5faWQY",
            "BCABKAwSGgoSYnV5X3Rva2VuX3F1YW50aXR5GAUgASgDIkQKGU1hcmtldENh",
            "bmNlbE9yZGVyQ29udHJhY3QSFQoNb3duZXJfYWRkcmVzcxgBIAEoDBIQCghv",
            "cmRlcl9pZBgCIAEoDEJFChhvcmcudHJvbi5wcm90b3MuY29udHJhY3RaKWdp",
            "dGh1Yi5jb20vdHJvbnByb3RvY29sL2dycGMtZ2F0ZXdheS9jb3JlYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.MarketSellAssetContract), global::Protocol.MarketSellAssetContract.Parser, new[]{ "OwnerAddress", "SellTokenId", "SellTokenQuantity", "BuyTokenId", "BuyTokenQuantity" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.MarketCancelOrderContract), global::Protocol.MarketCancelOrderContract.Parser, new[]{ "OwnerAddress", "OrderId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MarketSellAssetContract : pb::IMessage<MarketSellAssetContract> {
    private static readonly pb::MessageParser<MarketSellAssetContract> _parser = new pb::MessageParser<MarketSellAssetContract>(() => new MarketSellAssetContract());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MarketSellAssetContract> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.MarketContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketSellAssetContract() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketSellAssetContract(MarketSellAssetContract other) : this() {
      ownerAddress_ = other.ownerAddress_;
      sellTokenId_ = other.sellTokenId_;
      sellTokenQuantity_ = other.sellTokenQuantity_;
      buyTokenId_ = other.buyTokenId_;
      buyTokenQuantity_ = other.buyTokenQuantity_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketSellAssetContract Clone() {
      return new MarketSellAssetContract(this);
    }

    /// <summary>Field number for the "owner_address" field.</summary>
    public const int OwnerAddressFieldNumber = 1;
    private pb::ByteString ownerAddress_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString OwnerAddress {
      get { return ownerAddress_; }
      set {
        ownerAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sell_token_id" field.</summary>
    public const int SellTokenIdFieldNumber = 2;
    private pb::ByteString sellTokenId_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString SellTokenId {
      get { return sellTokenId_; }
      set {
        sellTokenId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sell_token_quantity" field.</summary>
    public const int SellTokenQuantityFieldNumber = 3;
    private long sellTokenQuantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long SellTokenQuantity {
      get { return sellTokenQuantity_; }
      set {
        sellTokenQuantity_ = value;
      }
    }

    /// <summary>Field number for the "buy_token_id" field.</summary>
    public const int BuyTokenIdFieldNumber = 4;
    private pb::ByteString buyTokenId_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString BuyTokenId {
      get { return buyTokenId_; }
      set {
        buyTokenId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "buy_token_quantity" field.</summary>
    public const int BuyTokenQuantityFieldNumber = 5;
    private long buyTokenQuantity_;
    /// <summary>
    /// min to receive
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BuyTokenQuantity {
      get { return buyTokenQuantity_; }
      set {
        buyTokenQuantity_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MarketSellAssetContract);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MarketSellAssetContract other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OwnerAddress != other.OwnerAddress) return false;
      if (SellTokenId != other.SellTokenId) return false;
      if (SellTokenQuantity != other.SellTokenQuantity) return false;
      if (BuyTokenId != other.BuyTokenId) return false;
      if (BuyTokenQuantity != other.BuyTokenQuantity) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OwnerAddress.Length != 0) hash ^= OwnerAddress.GetHashCode();
      if (SellTokenId.Length != 0) hash ^= SellTokenId.GetHashCode();
      if (SellTokenQuantity != 0L) hash ^= SellTokenQuantity.GetHashCode();
      if (BuyTokenId.Length != 0) hash ^= BuyTokenId.GetHashCode();
      if (BuyTokenQuantity != 0L) hash ^= BuyTokenQuantity.GetHashCode();
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
      if (OwnerAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(OwnerAddress);
      }
      if (SellTokenId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(SellTokenId);
      }
      if (SellTokenQuantity != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(SellTokenQuantity);
      }
      if (BuyTokenId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(BuyTokenId);
      }
      if (BuyTokenQuantity != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(BuyTokenQuantity);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OwnerAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(OwnerAddress);
      }
      if (SellTokenId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(SellTokenId);
      }
      if (SellTokenQuantity != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SellTokenQuantity);
      }
      if (BuyTokenId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(BuyTokenId);
      }
      if (BuyTokenQuantity != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BuyTokenQuantity);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MarketSellAssetContract other) {
      if (other == null) {
        return;
      }
      if (other.OwnerAddress.Length != 0) {
        OwnerAddress = other.OwnerAddress;
      }
      if (other.SellTokenId.Length != 0) {
        SellTokenId = other.SellTokenId;
      }
      if (other.SellTokenQuantity != 0L) {
        SellTokenQuantity = other.SellTokenQuantity;
      }
      if (other.BuyTokenId.Length != 0) {
        BuyTokenId = other.BuyTokenId;
      }
      if (other.BuyTokenQuantity != 0L) {
        BuyTokenQuantity = other.BuyTokenQuantity;
      }
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
            OwnerAddress = input.ReadBytes();
            break;
          }
          case 18: {
            SellTokenId = input.ReadBytes();
            break;
          }
          case 24: {
            SellTokenQuantity = input.ReadInt64();
            break;
          }
          case 34: {
            BuyTokenId = input.ReadBytes();
            break;
          }
          case 40: {
            BuyTokenQuantity = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MarketCancelOrderContract : pb::IMessage<MarketCancelOrderContract> {
    private static readonly pb::MessageParser<MarketCancelOrderContract> _parser = new pb::MessageParser<MarketCancelOrderContract>(() => new MarketCancelOrderContract());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MarketCancelOrderContract> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.MarketContractReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketCancelOrderContract() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketCancelOrderContract(MarketCancelOrderContract other) : this() {
      ownerAddress_ = other.ownerAddress_;
      orderId_ = other.orderId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketCancelOrderContract Clone() {
      return new MarketCancelOrderContract(this);
    }

    /// <summary>Field number for the "owner_address" field.</summary>
    public const int OwnerAddressFieldNumber = 1;
    private pb::ByteString ownerAddress_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString OwnerAddress {
      get { return ownerAddress_; }
      set {
        ownerAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "order_id" field.</summary>
    public const int OrderIdFieldNumber = 2;
    private pb::ByteString orderId_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString OrderId {
      get { return orderId_; }
      set {
        orderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MarketCancelOrderContract);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MarketCancelOrderContract other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OwnerAddress != other.OwnerAddress) return false;
      if (OrderId != other.OrderId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OwnerAddress.Length != 0) hash ^= OwnerAddress.GetHashCode();
      if (OrderId.Length != 0) hash ^= OrderId.GetHashCode();
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
      if (OwnerAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(OwnerAddress);
      }
      if (OrderId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(OrderId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OwnerAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(OwnerAddress);
      }
      if (OrderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(OrderId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MarketCancelOrderContract other) {
      if (other == null) {
        return;
      }
      if (other.OwnerAddress.Length != 0) {
        OwnerAddress = other.OwnerAddress;
      }
      if (other.OrderId.Length != 0) {
        OrderId = other.OrderId;
      }
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
            OwnerAddress = input.ReadBytes();
            break;
          }
          case 18: {
            OrderId = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
