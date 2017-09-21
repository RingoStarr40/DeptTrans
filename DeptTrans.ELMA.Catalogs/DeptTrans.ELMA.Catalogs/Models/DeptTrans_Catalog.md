<?xml version="1.0" encoding="utf-8"?>
<Entity xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Uid>0a89b5ac-ba2c-4283-a3ab-7738cae7a505</Uid>
  <Name>DeptTrans_Catalog</Name>
  <DisplayName>Список справочников</DisplayName>
  <Images />
  <NamedImages />
  <Namespace>DeptTrans.ELMA.Catalogs.Models</Namespace>
  <BaseClassUid>00000000-0000-0000-0000-000000000000</BaseClassUid>
  <Properties>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>d9b1a2a9-cf6a-4df5-872c-898060e775a9</Uid>
      <Name>Uid</Name>
      <DisplayName>UID</DisplayName>
      <Images />
      <NamedImages />
      <TypeUid>eb6e8ddc-fafe-4e0e-9018-1a7667012579</TypeUid>
      <SubTypeUid>00000000-0000-0000-0000-000000000000</SubTypeUid>
      <Settings xsi:type="GuidSettings">
        <FieldName>Uid</FieldName>
      </Settings>
      <Nullable>false</Nullable>
      <IsSystem>true</IsSystem>
      <OwnerPropertyUid>00000000-0000-0000-0000-000000000000</OwnerPropertyUid>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <Visibility>Hidden</Visibility>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>0</Order>
      <Handlers />
      <TypeResolver>00000000-0000-0000-0000-000000000000</TypeResolver>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>4ded7db4-13f2-4197-b9fc-fd764423688a</Uid>
      <Name>Spravochnik</Name>
      <DisplayName>Справочник</DisplayName>
      <Images />
      <NamedImages />
      <TypeUid>2df8e9ca-3ac4-4ba5-832f-18f6374397e7</TypeUid>
      <SubTypeUid>00000000-0000-0000-0000-000000000000</SubTypeUid>
      <Settings xsi:type="ReferenceOnEntityTypeSettings">
        <FieldName>Spravochnik</FieldName>
      </Settings>
      <Nullable>true</Nullable>
      <OwnerPropertyUid>00000000-0000-0000-0000-000000000000</OwnerPropertyUid>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <ViewType>Create</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Edit</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Display</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>List</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Filter</ViewType>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>1</Order>
      <Handlers />
      <TypeResolver>00000000-0000-0000-0000-000000000000</TypeResolver>
      <Filterable>true</Filterable>
    </PropertyMetadata>
  </Properties>
  <FormsScheme>FormConstructor</FormsScheme>
  <DefaultForms>
    <CreateUid>00000000-0000-0000-0000-000000000000</CreateUid>
    <EditUid>00000000-0000-0000-0000-000000000000</EditUid>
    <DisplayUid>00000000-0000-0000-0000-000000000000</DisplayUid>
    <ActionGuids />
    <FormSettings />
  </DefaultForms>
  <Forms>
    <FormViewItem>
      <Name>Form</Name>
      <Uid>3ff68071-bbdd-41fe-a6dc-f9fa978a512c</Uid>
      <MetadataUid xsi:nil="true" />
      <Items>
        <RootViewItem xsi:type="PanelViewItem">
          <Name>Panel1</Name>
          <Uid>17f18aba-8ce4-4818-ab4e-d4b22dbf0d36</Uid>
          <MetadataUid xsi:nil="true" />
          <Items>
            <RootViewItem xsi:type="ColumnViewItem">
              <Name>Column1</Name>
              <Uid>29956ff7-719a-42a4-a609-5221215ba8c3</Uid>
              <MetadataUid xsi:nil="true" />
              <Items>
                <RootViewItem xsi:type="PropertyViewItem">
                  <Name>Property1</Name>
                  <Uid>e605fb59-9734-4a46-90d7-bfd338f50c23</Uid>
                  <MetadataUid xsi:nil="true" />
                  <Items />
                  <Property>4ded7db4-13f2-4197-b9fc-fd764423688a</Property>
                  <Attributes>
                    <TablePartParentMetadataUid>00000000-0000-0000-0000-000000000000</TablePartParentMetadataUid>
                    <ViewProviderUid>00000000-0000-0000-0000-000000000000</ViewProviderUid>
                    <DynamicFormsProviderUid>00000000-0000-0000-0000-000000000000</DynamicFormsProviderUid>
                    <EntityFilterProvider>00000000-0000-0000-0000-000000000000</EntityFilterProvider>
                    <EntityModelBinderProvider>00000000-0000-0000-0000-000000000000</EntityModelBinderProvider>
                    <Placeholder />
                    <Tooltip />
                  </Attributes>
                  <TypeSettings />
                </RootViewItem>
              </Items>
            </RootViewItem>
          </Items>
          <Caption>Запись справочника</Caption>
          <Style>Separator</Style>
        </RootViewItem>
      </Items>
      <DisplayName>Создание</DisplayName>
    </FormViewItem>
  </Forms>
  <FormTransformations />
  <FormViews />
  <TableViews>
    <TableView>
      <Uid>548e87a8-650e-4e25-83a3-3e9144c9f319</Uid>
      <ViewType>List</ViewType>
      <SortDescriptors />
      <GroupDescriptors />
    </TableView>
  </TableViews>
  <TitlePropertyUid>00000000-0000-0000-0000-000000000000</TitlePropertyUid>
  <Type>Interface</Type>
  <ImplementationUid>7f1e0dfa-c34c-4200-a75a-703ac7de4ee7</ImplementationUid>
  <IdTypeUid>d90a59af-7e47-48c5-8c4c-dad04834e6e3</IdTypeUid>
  <TableName>DeptTrans_Catalog</TableName>
  <IsSoftDeletable>true</IsSoftDeletable>
  <SaveHistory>true</SaveHistory>
  <ShowInCatalogList>true</ShowInCatalogList>
  <Filterable>true</Filterable>
  <ParentPropertyUid>00000000-0000-0000-0000-000000000000</ParentPropertyUid>
  <IsGroupPropertyUid>00000000-0000-0000-0000-000000000000</IsGroupPropertyUid>
  <Filter>
    <Uid>00000000-0000-0000-0000-000000000000</Uid>
    <Images />
    <NamedImages />
    <BaseClassUid>00000000-0000-0000-0000-000000000000</BaseClassUid>
    <Properties>
      <PropertyMetadata>
        <Uid>743659af-d61d-43af-ae30-2072d83f4b0a</Uid>
        <Name>TypeUidSpravochnika</Name>
        <DisplayName>TypeUid справочника</DisplayName>
        <Images />
        <NamedImages />
        <TypeUid>eb6e8ddc-fafe-4e0e-9018-1a7667012579</TypeUid>
        <SubTypeUid>00000000-0000-0000-0000-000000000000</SubTypeUid>
        <Settings xsi:type="GuidSettings">
          <FieldName>TypeUidSpravochnika</FieldName>
        </Settings>
        <Nullable>true</Nullable>
        <OwnerPropertyUid>00000000-0000-0000-0000-000000000000</OwnerPropertyUid>
        <ViewSettings>
          <Attributes>
            <ViewAttribute>
              <ViewType>Create</ViewType>
            </ViewAttribute>
            <ViewAttribute>
              <ViewType>Edit</ViewType>
            </ViewAttribute>
            <ViewAttribute>
              <ViewType>Display</ViewType>
              <ReadOnly>true</ReadOnly>
            </ViewAttribute>
            <ViewAttribute>
              <ViewType>List</ViewType>
              <Visibility>Hidden</Visibility>
            </ViewAttribute>
            <ViewAttribute>
              <ViewType>Filter</ViewType>
            </ViewAttribute>
          </Attributes>
        </ViewSettings>
        <Order>0</Order>
        <Handlers />
        <TypeResolver>00000000-0000-0000-0000-000000000000</TypeResolver>
      </PropertyMetadata>
    </Properties>
    <DefaultForms>
      <CreateUid>00000000-0000-0000-0000-000000000000</CreateUid>
      <EditUid>00000000-0000-0000-0000-000000000000</EditUid>
      <DisplayUid>00000000-0000-0000-0000-000000000000</DisplayUid>
      <ActionGuids />
      <FormSettings />
    </DefaultForms>
    <Forms />
    <FormTransformations />
    <FormViews />
    <TableViews />
    <TitlePropertyUid>00000000-0000-0000-0000-000000000000</TitlePropertyUid>
  </Filter>
  <ImplementedExtensionUids />
  <Actions>
    <Uid>00000000-0000-0000-0000-000000000000</Uid>
    <Images />
    <NamedImages />
    <BaseTypeUid>00000000-0000-0000-0000-000000000000</BaseTypeUid>
    <Values />
  </Actions>
  <TableParts />
</Entity>