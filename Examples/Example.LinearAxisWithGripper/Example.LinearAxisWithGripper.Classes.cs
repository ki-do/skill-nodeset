/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;
using Opc.Ua.Skills;

namespace Example.LinearAxisWithGripper
{
    #region GripperStartMethodState Class
    #if (!OPCUA_EXCLUDE_GripperStartMethodState)
    /// <summary>
    /// Stores an instance of the GripperStartMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GripperStartMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GripperStartMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new GripperStartMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8fAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0RJLyMAAABodHRwOi8vb3BjZm91bmRhdGlv" +
           "bi5vcmcvVUEvU2tpbGxzL/////8EYYIKBAAAAAEAFgAAAEdyaXBwZXJTdGFydE1ldGhvZFR5cGUBAbo6" +
           "AC8BAbo6ujoAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQG7OgAuAES7OgAA" +
           "lgIAAAABACoBARMAAAAEAAAAU3BhbgAL/////wAAAAAAAQAqAQEUAAAABQAAAEZvcmNlAAv/////AAAA" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public GripperStartMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            double span = (double)_inputArguments[0];
            double force = (double)_inputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    span,
                    force);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult GripperStartMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        double span,
        double force);
    #endif
    #endregion

    #region IGripperSkillState Class
    #if (!OPCUA_EXCLUDE_IGripperSkillState)
    /// <summary>
    /// Stores an instance of the IGripperSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IGripperSkillState : ISkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public IGripperSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Example.LinearAxisWithGripper.ObjectTypes.IGripperSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8fAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0RJLyMAAABodHRwOi8vb3BjZm91bmRhdGlv" +
           "bi5vcmcvVUEvU2tpbGxzL/////+EYIACAQAAAAEAGQAAAElHcmlwcGVyU2tpbGxUeXBlSW5zdGFuY2UB" +
           "Abw6AQG8Orw6AAAB/////wMAAAAVYKkKAgAAAAMACgAAAElkZW50aWZpZXIBAb06AC4ARL06AAAMDAAA" +
           "AEdyaXBwZXJTa2lsbAAM/////wEB/////wAAAAAVYKkKAgAAAAMADgAAAElzSW5zdGFudGlhYmxlAQG+" +
           "OgAuAES+OgAAAQAAAf////8BAf////8AAAAABGCACgEAAAADAAwAAABTdGF0ZU1hY2hpbmUBAcA6AC8B" +
           "A8g6wDoAAP////8TAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAcE6AC8BAMgKwToAAAAV////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHCOgAuAETCOgAAABH/////AQH/////AAAAAARhggoE" +
           "AAAAAwAFAAAAU3RhcnQBAc46AC8BA+I6zjoAAAEBAQAAAAA1AQEB8zoBAAAAF2CpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBzzoALgBEzzoAAJYCAAAAAQAqAQETAAAABAAAAFNwYW4AC/////8AAAAAAAEA" +
           "KgEBFAAAAAUAAABGb3JjZQAL/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAA" +
           "AAMABAAAAEhhbHQBAdE6AC8BAw870ToAAAEBAwAAAAA1AQEB9ToANQEBAf06ADUBAQEBOwAAAAAEYYIK" +
           "BAAAAAMABQAAAFJlc2V0AQHUOgAvAQMGO9Q6AAABAQEAAAAANQEBAfE6AAAAAARhggoEAAAAAwAGAAAA" +
           "UmVzdW1lAQHXOgAvAQMMO9c6AAABAQEAAAAANQEBAfs6AAAAAARhggoEAAAAAwAHAAAAU3VzcGVuZAEB" +
           "2joALwEDCTvaOgAAAQEBAAAAADUBAQH5OgAAAAAEYIAKAQAAAAMABwAAAFJ1bm5pbmcBAd06AC8BA7o6" +
           "3ToAAAUAAAAANAEBAfM6ADMBAQH1OgAzAQEB9zoAMwEBAfk6ADQBAQH7OgIAAAAVYIkKAgAAAAAACwAA" +
           "AFN0YXRlTnVtYmVyAQHeOgAuAETeOgAAAAf/////AQH/////AAAAAARggAoBAAAAAwATAAAAQ29udGlu" +
           "dW91c1BhcmFtZXRlcgEB3zoALwA63zoAAP////8BAAAABGCACgEAAAADAA8AAABPdXRwdXRQYXJhbWV0" +
           "ZXIBAeE6AC8AOuE6AAD/////AQAAADVgiQoCAAAAAQAMAAAAQ3VycmVudEZvcmNlAQEDOwMAAAAAKwAA" +
           "AEN1cnJlbnQgZm9yY2UgYWN0aW5nIG9uIHRoZSBncmlwcGVyIGZpbmdlcnMALwA/AzsAAAAL/////wEB" +
           "/////wAAAAAEYIAKAQAAAAMABQAAAFJlYWR5AQHiOgAvAQO6OuI6AAAFAAAAADQBAQHxOgAzAQEB8zoA" +
           "NAEBAfc6ADQBAQH/OgAzAQEBATsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB4zoALgBE4zoA" +
           "AAAH/////wEB/////wAAAAAEYIAKAQAAAAMABgAAAEhhbHRlZAEB5zoALwEDujrnOgAABAAAAAAzAQEB" +
           "8ToANAEBAfU6ADQBAQH9OgA0AQEBATsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB6DoALgBE" +
           "6DoAAAAH/////wEB/////wAAAAAEYIAKAQAAAAMACQAAAFN1c3BlbmRlZAEB7DoALwEDujrsOgAABAAA" +
           "AAA0AQEB+ToAMwEBAfs6ADMBAQH9OgAzAQEB/zoBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB" +
           "7ToALgBE7ToAAAAH/////wEB/////wAAAAAEYIAKAQAAAAMADQAAAEhhbHRlZFRvUmVhZHkBAfE6AC8B" +
           "AAYJ8ToAAAQAAAAAMwABAec6ADQAAQHiOgA1AAEB1DoANgABA+U6AQAAABVgiQoCAAAAAAAQAAAAVHJh" +
           "bnNpdGlvbk51bWJlcgEB8joALgBE8joAAAAH/////wEB/////wAAAAAEYIAKAQAAAAMADgAAAFJlYWR5" +
           "VG9SdW5uaW5nAQHzOgAvAQAGCfM6AAAEAAAAADMAAQHiOgA0AAEB3ToANQABAc46ADYAAQPlOgEAAAAV" +
           "YIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAfQ6AC4ARPQ6AAAAB/////8BAf////8AAAAABGCA" +
           "CgEAAAADAA8AAABSdW5uaW5nVG9IYWx0ZWQBAfU6AC8BAAYJ9ToAAAQAAAAAMwABAd06ADQAAQHnOgA1" +
           "AAEB0ToANgABA+U6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB9joALgBE9joAAAAH" +
           "/////wEB/////wAAAAAEYIAKAQAAAAMADgAAAFJ1bm5pbmdUb1JlYWR5AQH3OgAvAQAGCfc6AAADAAAA" +
           "ADMAAQHdOgA0AAEB4joANgABA+U6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB+DoA" +
           "LgBE+DoAAAAH/////wEB/////wAAAAAEYIAKAQAAAAMAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEB+ToA" +
           "LwEABgn5OgAABAAAAAAzAAEB3ToANAABAew6ADUAAQHaOgA2AAED5ToBAAAAFWCJCgIAAAAAABAAAABU" +
           "cmFuc2l0aW9uTnVtYmVyAQH6OgAuAET6OgAAAAf/////AQH/////AAAAAARggAoBAAAAAwASAAAAU3Vz" +
           "cGVuZGVkVG9SdW5uaW5nAQH7OgAvAQAGCfs6AAAEAAAAADMAAQHsOgA0AAEB3ToANQABAdc6ADYAAQPl" +
           "OgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAfw6AC4ARPw6AAAAB/////8BAf////8A" +
           "AAAABGCACgEAAAADABEAAABTdXNwZW5kZWRUb0hhbHRlZAEB/ToALwEABgn9OgAABAAAAAAzAAEB7DoA" +
           "NAABAec6ADUAAQHROgA2AAED5ToBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQH+OgAu" +
           "AET+OgAAAAf/////AQH/////AAAAAARggAoBAAAAAwAQAAAAU3VzcGVuZGVkVG9SZWFkeQEB/zoALwEA" +
           "Bgn/OgAAAwAAAAAzAAEB7DoANAABAeI6ADYAAQPlOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25O" +
           "dW1iZXIBAQA7AC4ARAA7AAAAB/////8BAf////8AAAAABGCACgEAAAADAA0AAABSZWFkeVRvSGFsdGVk" +
           "AQEBOwAvAQAGCQE7AAAEAAAAADMAAQHiOgA0AAEB5zoANQABAdE6ADYAAQPlOgEAAAAVYIkKAgAAAAAA" +
           "EAAAAFRyYW5zaXRpb25OdW1iZXIBAQI7AC4ARAI7AAAAB/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MoveToAbsStartMethodState Class
    #if (!OPCUA_EXCLUDE_MoveToAbsStartMethodState)
    /// <summary>
    /// Stores an instance of the MoveToAbsStartMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MoveToAbsStartMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MoveToAbsStartMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new MoveToAbsStartMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8fAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0RJLyMAAABodHRwOi8vb3BjZm91bmRhdGlv" +
           "bi5vcmcvVUEvU2tpbGxzL/////8EYYIKBAAAAAEAGAAAAE1vdmVUb0Fic1N0YXJ0TWV0aG9kVHlwZQEB" +
           "BDsALwEBBDsEOwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQU7AC4ARAU7" +
           "AACWAQAAAAEAKgEBFwAAAAgAAABQb3NpdGlvbgAL/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public MoveToAbsStartMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            double position = (double)_inputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    position);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult MoveToAbsStartMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        double position);
    #endif
    #endregion

    #region IMoveToAbsSkillState Class
    #if (!OPCUA_EXCLUDE_IMoveToAbsSkillState)
    /// <summary>
    /// Stores an instance of the IMoveToAbsSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IMoveToAbsSkillState : ISkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public IMoveToAbsSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Example.LinearAxisWithGripper.ObjectTypes.IMoveToAbsSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8fAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0RJLyMAAABodHRwOi8vb3BjZm91bmRhdGlv" +
           "bi5vcmcvVUEvU2tpbGxzL/////+EYIACAQAAAAEAGwAAAElNb3ZlVG9BYnNTa2lsbFR5cGVJbnN0YW5j" +
           "ZQEBBjsBAQY7BjsAAAH/////AwAAABVgqQoCAAAAAwAKAAAASWRlbnRpZmllcgEBBzsALgBEBzsAAAwO" +
           "AAAATW92ZVRvQWJzU2tpbGwADP////8BAf////8AAAAAFWCpCgIAAAADAA4AAABJc0luc3RhbnRpYWJs" +
           "ZQEBCDsALgBECDsAAAEAAAH/////AQH/////AAAAAARggAoBAAAAAwAMAAAAU3RhdGVNYWNoaW5lAQEK" +
           "OwAvAQPIOgo7AAD/////EwAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQELOwAvAQDICgs7AAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBDDsALgBEDDsAAAAR/////wEB/////wAAAAAE" +
           "YYIKBAAAAAMABQAAAFN0YXJ0AQEYOwAvAQPiOhg7AAABAQEAAAAANQEBAT07AQAAABdgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBARk7AC4ARBk7AACWAQAAAAEAKgEBFwAAAAgAAABQb3NpdGlvbgAL////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAMABAAAAEhhbHQBARs7AC8BAw87" +
           "GzsAAAEBAwAAAAA1AQEBPzsANQEBAUc7ADUBAQFLOwAAAAAEYYIKBAAAAAMABQAAAFJlc2V0AQEeOwAv" +
           "AQMGOx47AAABAQEAAAAANQEBATs7AAAAAARhggoEAAAAAwAGAAAAUmVzdW1lAQEhOwAvAQMMOyE7AAAB" +
           "AQEAAAAANQEBAUU7AAAAAARhggoEAAAAAwAHAAAAU3VzcGVuZAEBJDsALwEDCTskOwAAAQEBAAAAADUB" +
           "AQFDOwAAAAAEYIAKAQAAAAMABwAAAFJ1bm5pbmcBASc7AC8BA7o6JzsAAAUAAAAANAEBAT07ADMBAQE/" +
           "OwAzAQEBQTsAMwEBAUM7ADQBAQFFOwIAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQEoOwAuAEQo" +
           "OwAAAAf/////AQH/////AAAAAARggAoBAAAAAwATAAAAQ29udGludW91c1BhcmFtZXRlcgEBKTsALwA6" +
           "KTsAAP////8BAAAABGCACgEAAAADAA8AAABPdXRwdXRQYXJhbWV0ZXIBASs7AC8AOis7AAD/////AQAA" +
           "ADVgiQoCAAAAAQAPAAAAQ3VycmVudFBvc2l0aW9uAQFNOwMAAAAAIwAAAEN1cnJlbnQgcG9zaXRpb24g" +
           "b2YgdGhlIGxpbmVhciBheGlzAC8AP007AAAAC/////8BAf////8AAAAABGCACgEAAAADAAUAAABSZWFk" +
           "eQEBLDsALwEDujosOwAABQAAAAA0AQEBOzsAMwEBAT07ADQBAQFBOwA0AQEBSTsAMwEBAUs7AQAAABVg" +
           "iQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAS07AC4ARC07AAAAB/////8BAf////8AAAAABGCACgEAAAAD" +
           "AAYAAABIYWx0ZWQBATE7AC8BA7o6MTsAAAQAAAAAMwEBATs7ADQBAQE/OwA0AQEBRzsANAEBAUs7AQAA" +
           "ABVgiQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBATI7AC4ARDI7AAAAB/////8BAf////8AAAAABGCACgEA" +
           "AAADAAkAAABTdXNwZW5kZWQBATY7AC8BA7o6NjsAAAQAAAAANAEBAUM7ADMBAQFFOwAzAQEBRzsAMwEB" +
           "AUk7AQAAABVgiQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBATc7AC4ARDc7AAAAB/////8BAf////8AAAAA" +
           "BGCACgEAAAADAA0AAABIYWx0ZWRUb1JlYWR5AQE7OwAvAQAGCTs7AAAEAAAAADMAAQExOwA0AAEBLDsA" +
           "NQABAR47ADYAAQPlOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBATw7AC4ARDw7AAAA" +
           "B/////8BAf////8AAAAABGCACgEAAAADAA4AAABSZWFkeVRvUnVubmluZwEBPTsALwEABgk9OwAABAAA" +
           "AAAzAAEBLDsANAABASc7ADUAAQEYOwA2AAED5ToBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVt" +
           "YmVyAQE+OwAuAEQ+OwAAAAf/////AQH/////AAAAAARggAoBAAAAAwAPAAAAUnVubmluZ1RvSGFsdGVk" +
           "AQE/OwAvAQAGCT87AAAEAAAAADMAAQEnOwA0AAEBMTsANQABARs7ADYAAQPlOgEAAAAVYIkKAgAAAAAA" +
           "EAAAAFRyYW5zaXRpb25OdW1iZXIBAUA7AC4AREA7AAAAB/////8BAf////8AAAAABGCACgEAAAADAA4A" +
           "AABSdW5uaW5nVG9SZWFkeQEBQTsALwEABglBOwAAAwAAAAAzAAEBJzsANAABASw7ADYAAQPlOgEAAAAV" +
           "YIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAUI7AC4AREI7AAAAB/////8BAf////8AAAAABGCA" +
           "CgEAAAADABIAAABSdW5uaW5nVG9TdXNwZW5kZWQBAUM7AC8BAAYJQzsAAAQAAAAAMwABASc7ADQAAQE2" +
           "OwA1AAEBJDsANgABA+U6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBRDsALgBERDsA" +
           "AAAH/////wEB/////wAAAAAEYIAKAQAAAAMAEgAAAFN1c3BlbmRlZFRvUnVubmluZwEBRTsALwEABglF" +
           "OwAABAAAAAAzAAEBNjsANAABASc7ADUAAQEhOwA2AAED5ToBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0" +
           "aW9uTnVtYmVyAQFGOwAuAERGOwAAAAf/////AQH/////AAAAAARggAoBAAAAAwARAAAAU3VzcGVuZGVk" +
           "VG9IYWx0ZWQBAUc7AC8BAAYJRzsAAAQAAAAAMwABATY7ADQAAQExOwA1AAEBGzsANgABA+U6AQAAABVg" +
           "iQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBSDsALgBESDsAAAAH/////wEB/////wAAAAAEYIAK" +
           "AQAAAAMAEAAAAFN1c3BlbmRlZFRvUmVhZHkBAUk7AC8BAAYJSTsAAAMAAAAAMwABATY7ADQAAQEsOwA2" +
           "AAED5ToBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFKOwAuAERKOwAAAAf/////AQH/" +
           "////AAAAAARggAoBAAAAAwANAAAAUmVhZHlUb0hhbHRlZAEBSzsALwEABglLOwAABAAAAAAzAAEBLDsA" +
           "NAABATE7ADUAAQEbOwA2AAED5ToBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFMOwAu" +
           "AERMOwAAAAf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}