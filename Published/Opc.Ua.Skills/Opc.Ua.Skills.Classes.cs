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

namespace Opc.Ua.Skills
{
    #region SkillStateState Class
    #if (!OPCUA_EXCLUDE_SkillStateState)
    /// <summary>
    /// Stores an instance of the SkillStateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillStateState : StateMachineStateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Skills.ObjectTypes.SkillStateType, Opc.Ua.Skills.Namespaces.OpcUaSkills, namespaceUris);
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

            if (ContinuousParameter != null)
            {
                ContinuousParameter.Initialize(context, ContinuousParameter_InitializationString);
            }
        }

        #region Initialization String
        private const string ContinuousParameter_InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////8EYIAKAQAAAAEAEwAA" +
           "AENvbnRpbnVvdXNQYXJhbWV0ZXIBAbw6AC8AOrw6AAD/////AgAAAARggAoBAAAAAQAOAAAASW5wdXRQ" +
           "YXJhbWV0ZXIBAb06AC8AOr06AAD/////AAAAAARggAoBAAAAAQAPAAAAT3V0cHV0UGFyYW1ldGVyAQG+" +
           "OgAvADq+OgAA/////wAAAAA=";

        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////8EYIACAQAAAAEAFgAA" +
           "AFNraWxsU3RhdGVUeXBlSW5zdGFuY2UBAbo6AQG6Oro6AAD/////AgAAABVgiQoCAAAAAAALAAAAU3Rh" +
           "dGVOdW1iZXIBAbs6AC4ARLs6AAAAB/////8BAf////8AAAAABGCACgEAAAABABMAAABDb250aW51b3Vz" +
           "UGFyYW1ldGVyAQG8OgAvADq8OgAA/////wIAAAAEYIAKAQAAAAEADgAAAElucHV0UGFyYW1ldGVyAQG9" +
           "OgAvADq9OgAA/////wAAAAAEYIAKAQAAAAEADwAAAE91dHB1dFBhcmFtZXRlcgEBvjoALwA6vjoAAP//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState ContinuousParameter
        {
            get
            {
                return m_continuousParameter;
            }

            set
            {
                if (!Object.ReferenceEquals(m_continuousParameter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_continuousParameter = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_continuousParameter != null)
            {
                children.Add(m_continuousParameter);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Skills.BrowseNames.ContinuousParameter:
                {
                    if (createOrReplace)
                    {
                        if (ContinuousParameter == null)
                        {
                            if (replacement == null)
                            {
                                ContinuousParameter = new BaseObjectState(this);
                            }
                            else
                            {
                                ContinuousParameter = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ContinuousParameter;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_continuousParameter;
        #endregion
    }
    #endif
    #endregion

    #region SkillStateTransitionEventState Class
    #if (!OPCUA_EXCLUDE_SkillStateTransitionEventState)
    /// <summary>
    /// Stores an instance of the SkillStateTransitionEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillStateTransitionEventState : TransitionEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillStateTransitionEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Skills.ObjectTypes.SkillStateTransitionEventType, Opc.Ua.Skills.Namespaces.OpcUaSkills, namespaceUris);
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
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////8EYIACAQAAAAEAJQAA" +
           "AFNraWxsU3RhdGVUcmFuc2l0aW9uRXZlbnRUeXBlSW5zdGFuY2UBAeU6AQHlOuU6AAD/////CwAAABVg" +
           "iQoCAAAAAAAHAAAARXZlbnRJZAEB6joALgBE6joAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAA" +
           "AEV2ZW50VHlwZQEB6zoALgBE6zoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5v" +
           "ZGUBAew6AC4AROw6AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHtOgAu" +
           "AETtOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEB7joALgBE7joAAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAe86AC4ARO86AAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAfE6AC4ARPE6AAAAFf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAgAAABTZXZlcml0eQEB8joALgBE8joAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFRy" +
           "YW5zaXRpb24BAeY6AC8BAMoK5joAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHnOgAu" +
           "AETnOgAAABj/////AQH/////AAAAABVgiQoCAAAAAAAJAAAARnJvbVN0YXRlAQH1OgAvAQDDCvU6AAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB9joALgBE9joAAAAY/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAFRvU3RhdGUBAfo6AC8BAMMK+joAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "AgAAAElkAQH7OgAuAET7OgAAABj/////AQH/////AAAAAA==";
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

    #region SkillStateMachineState Class
    #if (!OPCUA_EXCLUDE_SkillStateMachineState)
    /// <summary>
    /// Stores an instance of the SkillStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Skills.ObjectTypes.SkillStateMachineType, Opc.Ua.Skills.Namespaces.OpcUaSkills, namespaceUris);
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
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////+EYIACAQAAAAEAHQAA" +
           "AFNraWxsU3RhdGVNYWNoaW5lVHlwZUluc3RhbmNlAQHIOgEByDrIOgAAAf////8TAAAAFWCJCgIAAAAA" +
           "AAwAAABDdXJyZW50U3RhdGUBAck6AC8BAMgKyToAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQHKOgAuAETKOgAAABH/////AQH/////AAAAAARhggoEAAAAAQAFAAAAU3RhcnQBAeI6AC8BAeI6" +
           "4joAAAEBAQAAAAA1AQEBFzsAAAAABGGCCgQAAAABAAQAAABIYWx0AQEPOwAvAQEPOw87AAABAQMAAAAA" +
           "NQEBAQA7ADUBAQEFOwA1AQEBGzsAAAAABGGCCgQAAAABAAUAAABSZXNldAEBBjsALwEBBjsGOwAAAQEB" +
           "AAAAADUBAQEBOwAAAAAEYYIKBAAAAAEABgAAAFJlc3VtZQEBDDsALwEBDDsMOwAAAQEBAAAAADUBAQEZ" +
           "OwAAAAAEYYIKBAAAAAEABwAAAFN1c3BlbmQBAQk7AC8BAQk7CTsAAAEBAQAAAAA1AQEBFTsAAAAABGCA" +
           "CgEAAAABAAcAAABSdW5uaW5nAQHCOgAvAQG6OsI6AAAFAAAAADQBAQEXOwAzAQEBADsAMwEBAeE6ADMB" +
           "AQEVOwA0AQEBGTsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBvzoALgBEvzoAAAAH/////wEB" +
           "/////wAAAAAEYIAKAQAAAAEABQAAAFJlYWR5AQHXOgAvAQG6Otc6AAAFAAAAADQBAQEBOwAzAQEBFzsA" +
           "NAEBAeE6ADQBAQETOwAzAQEBGzsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB2DoALgBE2DoA" +
           "AAAH/////wEB/////wAAAAAEYIAKAQAAAAEABgAAAEhhbHRlZAEB3DoALwEBujrcOgAABAAAAAAzAQEB" +
           "ATsANAEBAQA7ADQBAQEFOwA0AQEBGzsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB3ToALgBE" +
           "3ToAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAFN1c3BlbmRlZAEBxDoALwEBujrEOgAABAAA" +
           "AAA0AQEBFTsAMwEBARk7ADMBAQEFOwAzAQEBEzsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB" +
           "xToALgBExToAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEADQAAAEhhbHRlZFRvUmVhZHkBAQE7AC8B" +
           "AAYJATsAAAQAAAAAMwABAdw6ADQAAQHXOgA1AAEBBjsANgABAeU6AQAAABVgiQoCAAAAAAAQAAAAVHJh" +
           "bnNpdGlvbk51bWJlcgEBAjsALgBEAjsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEADgAAAFJlYWR5" +
           "VG9SdW5uaW5nAQEXOwAvAQAGCRc7AAAEAAAAADMAAQHXOgA0AAEBwjoANQABAeI6ADYAAQHlOgEAAAAV" +
           "YIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBARg7AC4ARBg7AAAAB/////8BAf////8AAAAABGCA" +
           "CgEAAAABAA8AAABSdW5uaW5nVG9IYWx0ZWQBAQA7AC8BAAYJADsAAAQAAAAAMwABAcI6ADQAAQHcOgA1" +
           "AAEBDzsANgABAeU6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBBDsALgBEBDsAAAAH" +
           "/////wEB/////wAAAAAEYIAKAQAAAAEADgAAAFJ1bm5pbmdUb1JlYWR5AQHhOgAvAQAGCeE6AAADAAAA" +
           "ADMAAQHCOgA0AAEB1zoANgABAeU6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB/zoA" +
           "LgBE/zoAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEBFTsA" +
           "LwEABgkVOwAABAAAAAAzAAEBwjoANAABAcQ6ADUAAQEJOwA2AAEB5ToBAAAAFWCJCgIAAAAAABAAAABU" +
           "cmFuc2l0aW9uTnVtYmVyAQEWOwAuAEQWOwAAAAf/////AQH/////AAAAAARggAoBAAAAAQASAAAAU3Vz" +
           "cGVuZGVkVG9SdW5uaW5nAQEZOwAvAQAGCRk7AAAEAAAAADMAAQHEOgA0AAEBwjoANQABAQw7ADYAAQHl" +
           "OgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBARo7AC4ARBo7AAAAB/////8BAf////8A" +
           "AAAABGCACgEAAAABABEAAABTdXNwZW5kZWRUb0hhbHRlZAEBBTsALwEABgkFOwAABAAAAAAzAAEBxDoA" +
           "NAABAdw6ADUAAQEPOwA2AAEB5ToBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQESOwAu" +
           "AEQSOwAAAAf/////AQH/////AAAAAARggAoBAAAAAQAQAAAAU3VzcGVuZGVkVG9SZWFkeQEBEzsALwEA" +
           "BgkTOwAAAwAAAAAzAAEBxDoANAABAdc6ADYAAQHlOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25O" +
           "dW1iZXIBARQ7AC4ARBQ7AAAAB/////8BAf////8AAAAABGCACgEAAAABAA0AAABSZWFkeVRvSGFsdGVk" +
           "AQEbOwAvAQAGCRs7AAAEAAAAADMAAQHXOgA0AAEB3DoANQABAQ87ADYAAQHlOgEAAAAVYIkKAgAAAAAA" +
           "EAAAAFRyYW5zaXRpb25OdW1iZXIBARw7AC4ARBw7AAAAB/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState Start
        {
            get
            {
                return m_startMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMethod = value;
            }
        }

        /// <remarks />
        public MethodState Halt
        {
            get
            {
                return m_haltMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_haltMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_haltMethod = value;
            }
        }

        /// <remarks />
        public MethodState Reset
        {
            get
            {
                return m_resetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetMethod = value;
            }
        }

        /// <remarks />
        public MethodState Resume
        {
            get
            {
                return m_resumeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resumeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resumeMethod = value;
            }
        }

        /// <remarks />
        public MethodState Suspend
        {
            get
            {
                return m_suspendMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspendMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspendMethod = value;
            }
        }

        /// <remarks />
        public SkillStateState Running
        {
            get
            {
                return m_running;
            }

            set
            {
                if (!Object.ReferenceEquals(m_running, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_running = value;
            }
        }

        /// <remarks />
        public SkillStateState Ready
        {
            get
            {
                return m_ready;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ready, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ready = value;
            }
        }

        /// <remarks />
        public SkillStateState Halted
        {
            get
            {
                return m_halted;
            }

            set
            {
                if (!Object.ReferenceEquals(m_halted, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_halted = value;
            }
        }

        /// <remarks />
        public SkillStateState Suspended
        {
            get
            {
                return m_suspended;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspended, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspended = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState HaltedToReady
        {
            get
            {
                return m_haltedToReady;
            }

            set
            {
                if (!Object.ReferenceEquals(m_haltedToReady, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_haltedToReady = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState ReadyToRunning
        {
            get
            {
                return m_readyToRunning;
            }

            set
            {
                if (!Object.ReferenceEquals(m_readyToRunning, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_readyToRunning = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState RunningToHalted
        {
            get
            {
                return m_runningToHalted;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runningToHalted, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runningToHalted = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState RunningToReady
        {
            get
            {
                return m_runningToReady;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runningToReady, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runningToReady = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState RunningToSuspended
        {
            get
            {
                return m_runningToSuspended;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runningToSuspended, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runningToSuspended = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState SuspendedToRunning
        {
            get
            {
                return m_suspendedToRunning;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspendedToRunning, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspendedToRunning = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState SuspendedToHalted
        {
            get
            {
                return m_suspendedToHalted;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspendedToHalted, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspendedToHalted = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState SuspendedToReady
        {
            get
            {
                return m_suspendedToReady;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspendedToReady, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspendedToReady = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState ReadyToHalted
        {
            get
            {
                return m_readyToHalted;
            }

            set
            {
                if (!Object.ReferenceEquals(m_readyToHalted, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_readyToHalted = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
            }

            if (m_haltMethod != null)
            {
                children.Add(m_haltMethod);
            }

            if (m_resetMethod != null)
            {
                children.Add(m_resetMethod);
            }

            if (m_resumeMethod != null)
            {
                children.Add(m_resumeMethod);
            }

            if (m_suspendMethod != null)
            {
                children.Add(m_suspendMethod);
            }

            if (m_running != null)
            {
                children.Add(m_running);
            }

            if (m_ready != null)
            {
                children.Add(m_ready);
            }

            if (m_halted != null)
            {
                children.Add(m_halted);
            }

            if (m_suspended != null)
            {
                children.Add(m_suspended);
            }

            if (m_haltedToReady != null)
            {
                children.Add(m_haltedToReady);
            }

            if (m_readyToRunning != null)
            {
                children.Add(m_readyToRunning);
            }

            if (m_runningToHalted != null)
            {
                children.Add(m_runningToHalted);
            }

            if (m_runningToReady != null)
            {
                children.Add(m_runningToReady);
            }

            if (m_runningToSuspended != null)
            {
                children.Add(m_runningToSuspended);
            }

            if (m_suspendedToRunning != null)
            {
                children.Add(m_suspendedToRunning);
            }

            if (m_suspendedToHalted != null)
            {
                children.Add(m_suspendedToHalted);
            }

            if (m_suspendedToReady != null)
            {
                children.Add(m_suspendedToReady);
            }

            if (m_readyToHalted != null)
            {
                children.Add(m_readyToHalted);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Skills.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new MethodState(this);
                            }
                            else
                            {
                                Start = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Halt:
                {
                    if (createOrReplace)
                    {
                        if (Halt == null)
                        {
                            if (replacement == null)
                            {
                                Halt = new MethodState(this);
                            }
                            else
                            {
                                Halt = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Halt;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Reset:
                {
                    if (createOrReplace)
                    {
                        if (Reset == null)
                        {
                            if (replacement == null)
                            {
                                Reset = new MethodState(this);
                            }
                            else
                            {
                                Reset = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Reset;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Resume:
                {
                    if (createOrReplace)
                    {
                        if (Resume == null)
                        {
                            if (replacement == null)
                            {
                                Resume = new MethodState(this);
                            }
                            else
                            {
                                Resume = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Resume;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Suspend:
                {
                    if (createOrReplace)
                    {
                        if (Suspend == null)
                        {
                            if (replacement == null)
                            {
                                Suspend = new MethodState(this);
                            }
                            else
                            {
                                Suspend = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Suspend;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Running:
                {
                    if (createOrReplace)
                    {
                        if (Running == null)
                        {
                            if (replacement == null)
                            {
                                Running = new SkillStateState(this);
                            }
                            else
                            {
                                Running = (SkillStateState)replacement;
                            }
                        }
                    }

                    instance = Running;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Ready:
                {
                    if (createOrReplace)
                    {
                        if (Ready == null)
                        {
                            if (replacement == null)
                            {
                                Ready = new SkillStateState(this);
                            }
                            else
                            {
                                Ready = (SkillStateState)replacement;
                            }
                        }
                    }

                    instance = Ready;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Halted:
                {
                    if (createOrReplace)
                    {
                        if (Halted == null)
                        {
                            if (replacement == null)
                            {
                                Halted = new SkillStateState(this);
                            }
                            else
                            {
                                Halted = (SkillStateState)replacement;
                            }
                        }
                    }

                    instance = Halted;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Suspended:
                {
                    if (createOrReplace)
                    {
                        if (Suspended == null)
                        {
                            if (replacement == null)
                            {
                                Suspended = new SkillStateState(this);
                            }
                            else
                            {
                                Suspended = (SkillStateState)replacement;
                            }
                        }
                    }

                    instance = Suspended;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.HaltedToReady:
                {
                    if (createOrReplace)
                    {
                        if (HaltedToReady == null)
                        {
                            if (replacement == null)
                            {
                                HaltedToReady = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                HaltedToReady = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = HaltedToReady;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.ReadyToRunning:
                {
                    if (createOrReplace)
                    {
                        if (ReadyToRunning == null)
                        {
                            if (replacement == null)
                            {
                                ReadyToRunning = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                ReadyToRunning = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = ReadyToRunning;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.RunningToHalted:
                {
                    if (createOrReplace)
                    {
                        if (RunningToHalted == null)
                        {
                            if (replacement == null)
                            {
                                RunningToHalted = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                RunningToHalted = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = RunningToHalted;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.RunningToReady:
                {
                    if (createOrReplace)
                    {
                        if (RunningToReady == null)
                        {
                            if (replacement == null)
                            {
                                RunningToReady = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                RunningToReady = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = RunningToReady;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.RunningToSuspended:
                {
                    if (createOrReplace)
                    {
                        if (RunningToSuspended == null)
                        {
                            if (replacement == null)
                            {
                                RunningToSuspended = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                RunningToSuspended = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = RunningToSuspended;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.SuspendedToRunning:
                {
                    if (createOrReplace)
                    {
                        if (SuspendedToRunning == null)
                        {
                            if (replacement == null)
                            {
                                SuspendedToRunning = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                SuspendedToRunning = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = SuspendedToRunning;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.SuspendedToHalted:
                {
                    if (createOrReplace)
                    {
                        if (SuspendedToHalted == null)
                        {
                            if (replacement == null)
                            {
                                SuspendedToHalted = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                SuspendedToHalted = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = SuspendedToHalted;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.SuspendedToReady:
                {
                    if (createOrReplace)
                    {
                        if (SuspendedToReady == null)
                        {
                            if (replacement == null)
                            {
                                SuspendedToReady = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                SuspendedToReady = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = SuspendedToReady;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.ReadyToHalted:
                {
                    if (createOrReplace)
                    {
                        if (ReadyToHalted == null)
                        {
                            if (replacement == null)
                            {
                                ReadyToHalted = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                ReadyToHalted = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = ReadyToHalted;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MethodState m_startMethod;
        private MethodState m_haltMethod;
        private MethodState m_resetMethod;
        private MethodState m_resumeMethod;
        private MethodState m_suspendMethod;
        private SkillStateState m_running;
        private SkillStateState m_ready;
        private SkillStateState m_halted;
        private SkillStateState m_suspended;
        private StateMachineTransitionState m_haltedToReady;
        private StateMachineTransitionState m_readyToRunning;
        private StateMachineTransitionState m_runningToHalted;
        private StateMachineTransitionState m_runningToReady;
        private StateMachineTransitionState m_runningToSuspended;
        private StateMachineTransitionState m_suspendedToRunning;
        private StateMachineTransitionState m_suspendedToHalted;
        private StateMachineTransitionState m_suspendedToReady;
        private StateMachineTransitionState m_readyToHalted;
        #endregion
    }
    #endif
    #endregion

    #region ISkillState Class
    #if (!OPCUA_EXCLUDE_ISkillState)
    /// <summary>
    /// Stores an instance of the ISkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ISkillState : BaseInterfaceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ISkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Skills.ObjectTypes.ISkillType, Opc.Ua.Skills.Namespaces.OpcUaSkills, namespaceUris);
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

            if (Functionality != null)
            {
                Functionality.Initialize(context, Functionality_InitializationString);
            }
        }

        #region Initialization String
        private const string Functionality_InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////8kYIAKAQAAAAEADQAA" +
           "AEZ1bmN0aW9uYWxpdHkBASA7AwAAAAB2AAAAT2JqZWN0IGRlc2NyaWJpbmcgdGhlIHNraWxsIGZ1bmN0" +
           "aW9uYWxpdHkgYnkgcmVmZXJlbmNpbmcgYSBEaXNjdGlvbmFyeUVudHJ5IHdpdGggcmVmZXJlbmNlIHR5" +
           "cGUgSGFzRGljdGlvbmFyeUVudHJ5VHlwZQAvADogOwAA/////wAAAAA=";

        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////+EYIACAQAAAAEAEgAA" +
           "AElTa2lsbFR5cGVJbnN0YW5jZQEBHTsBAR07HTsAAAH/////BAAAABVgiQoCAAAAAQAKAAAASWRlbnRp" +
           "ZmllcgEBIzsALgBEIzsAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADgAAAElzSW5zdGFudGlhYmxl" +
           "AQEfOwAuAEQfOwAAAAH/////AQH/////AAAAACRggAoBAAAAAQANAAAARnVuY3Rpb25hbGl0eQEBIDsD" +
           "AAAAAHYAAABPYmplY3QgZGVzY3JpYmluZyB0aGUgc2tpbGwgZnVuY3Rpb25hbGl0eSBieSByZWZlcmVu" +
           "Y2luZyBhIERpc2N0aW9uYXJ5RW50cnkgd2l0aCByZWZlcmVuY2UgdHlwZSBIYXNEaWN0aW9uYXJ5RW50" +
           "cnlUeXBlAC8AOiA7AAD/////AAAAAARggAoBAAAAAQAMAAAAU3RhdGVNYWNoaW5lAQEeOwAvAQHIOh47" +
           "AAD/////EwAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQEhOwAvAQDICiE7AAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEBIjsALgBEIjsAAAAR/////wEB/////wAAAAAEYYIKBAAAAAEA" +
           "BQAAAFN0YXJ0AQEvOwAvAQHiOi87AAABAQEAAAAANQEBAVQ7AAAAAARhggoEAAAAAQAEAAAASGFsdAEB" +
           "MjsALwEBDzsyOwAAAQEDAAAAADUBAQFWOwA1AQEBXjsANQEBAWI7AAAAAARhggoEAAAAAQAFAAAAUmVz" +
           "ZXQBATU7AC8BAQY7NTsAAAEBAQAAAAA1AQEBUjsAAAAABGGCCgQAAAABAAYAAABSZXN1bWUBATg7AC8B" +
           "AQw7ODsAAAEBAQAAAAA1AQEBXDsAAAAABGGCCgQAAAABAAcAAABTdXNwZW5kAQE7OwAvAQEJOzs7AAAB" +
           "AQEAAAAANQEBAVo7AAAAAARggAoBAAAAAQAHAAAAUnVubmluZwEBPjsALwEBujo+OwAABQAAAAA0AQEB" +
           "VDsAMwEBAVY7ADMBAQFYOwAzAQEBWjsANAEBAVw7AQAAABVgiQoCAAAAAAALAAAAU3RhdGVOdW1iZXIB" +
           "AT87AC4ARD87AAAAB/////8BAf////8AAAAABGCACgEAAAABAAUAAABSZWFkeQEBQzsALwEBujpDOwAA" +
           "BQAAAAA0AQEBUjsAMwEBAVQ7ADQBAQFYOwA0AQEBYDsAMwEBAWI7AQAAABVgiQoCAAAAAAALAAAAU3Rh" +
           "dGVOdW1iZXIBAUQ7AC4AREQ7AAAAB/////8BAf////8AAAAABGCACgEAAAABAAYAAABIYWx0ZWQBAUg7" +
           "AC8BAbo6SDsAAAQAAAAAMwEBAVI7ADQBAQFWOwA0AQEBXjsANAEBAWI7AQAAABVgiQoCAAAAAAALAAAA" +
           "U3RhdGVOdW1iZXIBAUk7AC4AREk7AAAAB/////8BAf////8AAAAABGCACgEAAAABAAkAAABTdXNwZW5k" +
           "ZWQBAU07AC8BAbo6TTsAAAQAAAAANAEBAVo7ADMBAQFcOwAzAQEBXjsAMwEBAWA7AQAAABVgiQoCAAAA" +
           "AAALAAAAU3RhdGVOdW1iZXIBAU47AC4ARE47AAAAB/////8BAf////8AAAAABGCACgEAAAABAA0AAABI" +
           "YWx0ZWRUb1JlYWR5AQFSOwAvAQAGCVI7AAAEAAAAADMAAQFIOwA0AAEBQzsANQABATU7ADYAAQHlOgEA" +
           "AAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAVM7AC4ARFM7AAAAB/////8BAf////8AAAAA" +
           "BGCACgEAAAABAA4AAABSZWFkeVRvUnVubmluZwEBVDsALwEABglUOwAABAAAAAAzAAEBQzsANAABAT47" +
           "ADUAAQEvOwA2AAEB5ToBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFVOwAuAERVOwAA" +
           "AAf/////AQH/////AAAAAARggAoBAAAAAQAPAAAAUnVubmluZ1RvSGFsdGVkAQFWOwAvAQAGCVY7AAAE" +
           "AAAAADMAAQE+OwA0AAEBSDsANQABATI7ADYAAQHlOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25O" +
           "dW1iZXIBAVc7AC4ARFc7AAAAB/////8BAf////8AAAAABGCACgEAAAABAA4AAABSdW5uaW5nVG9SZWFk" +
           "eQEBWDsALwEABglYOwAAAwAAAAAzAAEBPjsANAABAUM7ADYAAQHlOgEAAAAVYIkKAgAAAAAAEAAAAFRy" +
           "YW5zaXRpb25OdW1iZXIBAVk7AC4ARFk7AAAAB/////8BAf////8AAAAABGCACgEAAAABABIAAABSdW5u" +
           "aW5nVG9TdXNwZW5kZWQBAVo7AC8BAAYJWjsAAAQAAAAAMwABAT47ADQAAQFNOwA1AAEBOzsANgABAeU6" +
           "AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBWzsALgBEWzsAAAAH/////wEB/////wAA" +
           "AAAEYIAKAQAAAAEAEgAAAFN1c3BlbmRlZFRvUnVubmluZwEBXDsALwEABglcOwAABAAAAAAzAAEBTTsA" +
           "NAABAT47ADUAAQE4OwA2AAEB5ToBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFdOwAu" +
           "AERdOwAAAAf/////AQH/////AAAAAARggAoBAAAAAQARAAAAU3VzcGVuZGVkVG9IYWx0ZWQBAV47AC8B" +
           "AAYJXjsAAAQAAAAAMwABAU07ADQAAQFIOwA1AAEBMjsANgABAeU6AQAAABVgiQoCAAAAAAAQAAAAVHJh" +
           "bnNpdGlvbk51bWJlcgEBXzsALgBEXzsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEAEAAAAFN1c3Bl" +
           "bmRlZFRvUmVhZHkBAWA7AC8BAAYJYDsAAAMAAAAAMwABAU07ADQAAQFDOwA2AAEB5ToBAAAAFWCJCgIA" +
           "AAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFhOwAuAERhOwAAAAf/////AQH/////AAAAAARggAoBAAAA" +
           "AQANAAAAUmVhZHlUb0hhbHRlZAEBYjsALwEABgliOwAABAAAAAAzAAEBQzsANAABAUg7ADUAAQEyOwA2" +
           "AAEB5ToBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFjOwAuAERjOwAAAAf/////AQH/" +
           "////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Identifier
        {
            get
            {
                return m_identifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identifier = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> IsInstantiable
        {
            get
            {
                return m_isInstantiable;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isInstantiable, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isInstantiable = value;
            }
        }

        /// <remarks />
        public BaseObjectState Functionality
        {
            get
            {
                return m_functionality;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionality, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionality = value;
            }
        }

        /// <remarks />
        public SkillStateMachineState StateMachine
        {
            get
            {
                return m_stateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stateMachine = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_identifier != null)
            {
                children.Add(m_identifier);
            }

            if (m_isInstantiable != null)
            {
                children.Add(m_isInstantiable);
            }

            if (m_functionality != null)
            {
                children.Add(m_functionality);
            }

            if (m_stateMachine != null)
            {
                children.Add(m_stateMachine);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Skills.BrowseNames.Identifier:
                {
                    if (createOrReplace)
                    {
                        if (Identifier == null)
                        {
                            if (replacement == null)
                            {
                                Identifier = new PropertyState<string>(this);
                            }
                            else
                            {
                                Identifier = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Identifier;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.IsInstantiable:
                {
                    if (createOrReplace)
                    {
                        if (IsInstantiable == null)
                        {
                            if (replacement == null)
                            {
                                IsInstantiable = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsInstantiable = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsInstantiable;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Functionality:
                {
                    if (createOrReplace)
                    {
                        if (Functionality == null)
                        {
                            if (replacement == null)
                            {
                                Functionality = new BaseObjectState(this);
                            }
                            else
                            {
                                Functionality = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Functionality;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.StateMachine:
                {
                    if (createOrReplace)
                    {
                        if (StateMachine == null)
                        {
                            if (replacement == null)
                            {
                                StateMachine = new SkillStateMachineState(this);
                            }
                            else
                            {
                                StateMachine = (SkillStateMachineState)replacement;
                            }
                        }
                    }

                    instance = StateMachine;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_identifier;
        private PropertyState<bool> m_isInstantiable;
        private BaseObjectState m_functionality;
        private SkillStateMachineState m_stateMachine;
        #endregion
    }
    #endif
    #endregion

    #region SkillState Class
    #if (!OPCUA_EXCLUDE_SkillState)
    /// <summary>
    /// Stores an instance of the SkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Skills.ObjectTypes.SkillType, Opc.Ua.Skills.Namespaces.OpcUaSkills, namespaceUris);
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
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////8EYIACAQAAAAEAEQAA" +
           "AFNraWxsVHlwZUluc3RhbmNlAQFkOwEBZDtkOwAA/////wAAAAA=";
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