﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace MsCrmTools.MetadataBrowser.AppCode.LocalizedLabelMd
{
    // [TypeConverter(typeof(LocalizedLabelCollectionConverter))]
    public class LocalizedLabelCollection : CollectionBase, ICustomTypeDescriptor
    {
        private readonly List<LocalizedLabelInfo> list;

        public LocalizedLabelCollection()
        {
            list = new List<LocalizedLabelInfo>();
        }

        public new int Count
        {
            get { return list.Count; }
        }

        public LocalizedLabelInfo this[int index]
        {
            get { return list[index]; }
        }

        public void Add(LocalizedLabelInfo info)
        {
            list.Add(info);
        }

        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        public string GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            return GetProperties();
        }

        public PropertyDescriptorCollection GetProperties()
        {
            var pds = new PropertyDescriptorCollection(null);
            for (int i = 0; i < list.Count; i++)
            {
                var pd = new LocalizedLabelPropertyDescriptor(this, i);
                pds.Add(pd);
            }
            return pds;
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        public void Remove(LocalizedLabelInfo info)
        {
            list.Remove(info);
        }
    }
}