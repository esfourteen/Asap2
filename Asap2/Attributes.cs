﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class BaseAttribute : Attribute
    {
        // Private fields.
        private bool isSimple;
        private string ObsoleteMsg;

        public BaseAttribute()
        {
            this.isSimple = false;
        }

        /// <summary>
        /// Is this a simple type that shall not start with /begin. Default is complex type that starts with /begin.
        /// </summary>
        public virtual bool IsSimple
        {
            get { return isSimple; }
            set { isSimple = value; }
        }

        /// <summary>
        /// This type is Obsolete if this string is populated with a obsolete message.
        /// </summary>
        public virtual string IsObsolete
        {
            get { return ObsoleteMsg; }
            set { ObsoleteMsg = value; }
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class ElementAttribute : Attribute
    {
        // Private fields.
        private string name;
        private uint sortOrder;
        private string comment;
        private bool isName;
        private bool isArgument;
        private bool isString;
        private bool isComment;
        private bool isDictionary;
        private bool isList;
        private bool forceNewLine;
        private bool codeAsHex;
        private string ObsoleteMsg;

        public ElementAttribute(uint SortOrder)
        {
            this.sortOrder = SortOrder;
            this.isName = false;
            this.isArgument = false;
            this.isString = false;
            this.isComment = false;
            this.isDictionary = false;
            this.isList = false;
            this.forceNewLine = false;
            this.codeAsHex = false;
        }

        /// <summary>
        /// Name for the element. Replaces class name as element name.
        /// </summary>
        public virtual bool IsName
        {
            get { return isName; }
            set { isName = value; }
        }

        /// <summary>
        /// Is this an argument of an element.
        /// </summary>
        public virtual bool IsArgument
        {
            get { return isArgument; }
            set { isArgument = value; }
        }

        /// <summary>
        /// Is this a long argument of an element of string type.
        /// </summary>
        public virtual bool IsString
        {
            get { return isString; }
            set { isString = value; }
        }

        /// <summary>
        /// Is comment in an element.
        /// </summary>
        public virtual bool IsComment
        {
            get { return isComment; }
            set { isComment = value; }
        }


        /// <summary>
        /// Is a dictionary of type Dictionary&lt;string, object&gt;
        /// </summary>
        public virtual bool IsDictionary
        {
            get { return isDictionary; }
            set { isDictionary = value; }
        }

        /// <summary>
        /// Is a list of type List&lt;object&gt;. Object is a new node or simple data that can be fetched whith ToString().
        /// </summary>
        public virtual bool IsList
        {
            get { return isList; }
            set { isList = value; }
        }

        /// <summary>
        /// Force extra newline before this element.
        /// </summary>
        public virtual bool ForceNewLine
        {
            get { return forceNewLine; }
            set { forceNewLine = value; }
        }

        /// <summary>
        /// Code this element as hex.
        /// </summary>
        public virtual bool CodeAsHex
        {
            get { return codeAsHex; }
            set { codeAsHex = value; }
        }

        /// <summary>
        /// Override serialization name.
        /// </summary>
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Set serialization sortorder.
        /// </summary>
        public virtual uint SortOrder
        {
            get { return sortOrder; }
        }

        /// <summary>
        /// Optional comment.
        /// </summary>
        public virtual string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        /// <summary>
        /// This parameter is obsolete if this string is populated with a obsolete message.
        /// </summary>
        public virtual string IsObsolete
        {
            get { return ObsoleteMsg; }
            set { ObsoleteMsg = value; }
        }
    }
}
