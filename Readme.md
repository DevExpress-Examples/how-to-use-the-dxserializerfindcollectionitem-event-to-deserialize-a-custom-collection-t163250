# How to use the DXSerializer.FindCollectionItem event to deserialize a custom collection


<p>The DXSerializer.FindCollectionItem event is used when it's necessary to deserialize a custom collection and when deserialized items exist in the current layout. For example, the GridControl uses this event to deserialize columns. In this event handler, it searches for a deserialized column in the existing layout. If such a column is found, the GridControl doesn't create a new one. To deserialize an item from the deserialized collection, assign it to the XtraFindCollectionItemEventArgs.CollectionItem property. <br />This event is raised only if the XtraSerializableProperty.UseFindItem property is "True". </p>

<br/>


