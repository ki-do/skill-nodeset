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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;
using Opc.Ua.Skills;

namespace Example.LinearAxisWithGripper
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open = 15015;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close = 15018;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read = 15020;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write = 15023;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition = 15025;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition = 15028;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Start Method.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Start = 15054;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Halt Method.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Halt = 15057;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Reset Method.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Reset = 15060;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Resume Method.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Resume = 15063;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Suspend Method.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Suspend = 15066;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Start Method.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Start = 15128;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Halt Method.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Halt = 15131;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Reset Method.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Reset = 15134;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Resume Method.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Resume = 15137;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Suspend Method.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Suspend = 15140;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata Object.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata = 15001;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine = 15040;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Running Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Running = 15069;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Running_ContinuousParameter Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Running_ContinuousParameter = 15071;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Running_ContinuousParameter_OutputParameter = 15073;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Ready Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Ready = 15074;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Halted Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Halted = 15079;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Suspended Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Suspended = 15084;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_HaltedToReady = 15089;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_ReadyToRunning = 15091;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_RunningToHalted = 15093;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_RunningToReady = 15095;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_RunningToSuspended = 15097;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_SuspendedToRunning = 15099;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_SuspendedToHalted = 15101;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_SuspendedToReady = 15103;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_ReadyToHalted = 15105;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine = 15114;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Running Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Running = 15143;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter = 15145;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter_OutputParameter = 15147;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Ready Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Ready = 15148;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Halted Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Halted = 15153;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Suspended Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Suspended = 15158;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_HaltedToReady = 15163;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_ReadyToRunning = 15165;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_RunningToHalted = 15167;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_RunningToReady = 15169;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_RunningToSuspended = 15171;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_SuspendedToRunning = 15173;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_SuspendedToHalted = 15175;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_SuspendedToReady = 15177;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_ReadyToHalted = 15179;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the IGripperSkillType ObjectType.
        /// </summary>
        public const uint IGripperSkillType = 15036;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType ObjectType.
        /// </summary>
        public const uint IMoveToAbsSkillType = 15110;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceUri = 15002;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceVersion = 15003;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespacePublicationDate = 15004;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_IsNamespaceSubset = 15005;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_StaticNodeIdTypes = 15006;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_StaticNumericNodeIdRange = 15007;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_StaticStringNodeIdPattern = 15008;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Size = 15010;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Writable = 15011;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_UserWritable = 15012;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_OpenCount = 15013;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_InputArguments = 15016;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_OutputArguments = 15017;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close_InputArguments = 15019;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_InputArguments = 15021;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_OutputArguments = 15022;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write_InputArguments = 15024;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = 15026;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = 15027;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = 15029;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_DefaultRolePermissions = 15031;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_DefaultUserRolePermissions = 15032;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_DefaultAccessRestrictions = 15033;

        /// <summary>
        /// The identifier for the IGripperSkillType_Identifier Variable.
        /// </summary>
        public const uint IGripperSkillType_Identifier = 15037;

        /// <summary>
        /// The identifier for the IGripperSkillType_IsInstantiable Variable.
        /// </summary>
        public const uint IGripperSkillType_IsInstantiable = 15038;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_CurrentState = 15041;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_CurrentState_Id = 15042;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_LastTransition_Id = 15047;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Start_InputArguments = 15055;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Start_OutputArguments Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Start_OutputArguments = 15056;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Running_StateNumber = 15070;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Ready_StateNumber = 15075;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Halted_StateNumber = 15080;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Suspended_StateNumber = 15085;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_HaltedToReady_TransitionNumber = 15090;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_ReadyToRunning_TransitionNumber = 15092;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_RunningToHalted_TransitionNumber = 15094;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_RunningToReady_TransitionNumber = 15096;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_RunningToSuspended_TransitionNumber = 15098;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_SuspendedToRunning_TransitionNumber = 15100;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_SuspendedToHalted_TransitionNumber = 15102;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_SuspendedToReady_TransitionNumber = 15104;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_ReadyToHalted_TransitionNumber = 15106;

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce Variable.
        /// </summary>
        public const uint IGripperSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce = 15107;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_Identifier Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_Identifier = 15111;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_IsInstantiable Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_IsInstantiable = 15112;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_CurrentState = 15115;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_CurrentState_Id = 15116;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_LastTransition_Id = 15121;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Start_InputArguments = 15129;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Running_StateNumber = 15144;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Ready_StateNumber = 15149;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Halted_StateNumber = 15154;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Suspended_StateNumber = 15159;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_HaltedToReady_TransitionNumber = 15164;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_ReadyToRunning_TransitionNumber = 15166;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_RunningToHalted_TransitionNumber = 15168;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_RunningToReady_TransitionNumber = 15170;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_RunningToSuspended_TransitionNumber = 15172;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_SuspendedToRunning_TransitionNumber = 15174;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_SuspendedToHalted_TransitionNumber = 15176;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_SuspendedToReady_TransitionNumber = 15178;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_ReadyToHalted_TransitionNumber = 15180;

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition Variable.
        /// </summary>
        public const uint IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition = 15181;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Start = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.IGripperSkillType_StateMachine_Start, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Halt = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.IGripperSkillType_StateMachine_Halt, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Reset = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.IGripperSkillType_StateMachine_Reset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Resume = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.IGripperSkillType_StateMachine_Resume, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Suspend = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.IGripperSkillType_StateMachine_Suspend, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Start = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.IMoveToAbsSkillType_StateMachine_Start, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Halt = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.IMoveToAbsSkillType_StateMachine_Halt, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Reset = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.IMoveToAbsSkillType_StateMachine_Reset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Resume = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.IMoveToAbsSkillType_StateMachine_Resume, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Suspend = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.IMoveToAbsSkillType_StateMachine_Suspend, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata Object.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ExampleLinearAxisWithGripperNamespaceMetadata, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Running = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_Running, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Running_ContinuousParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Running_ContinuousParameter = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_Running_ContinuousParameter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Running_ContinuousParameter_OutputParameter = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_Running_ContinuousParameter_OutputParameter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Ready = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_Ready, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Halted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_Halted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Suspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_Suspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_HaltedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_HaltedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_ReadyToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_ReadyToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_RunningToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_RunningToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_RunningToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_RunningToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_RunningToSuspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_RunningToSuspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_SuspendedToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_SuspendedToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_SuspendedToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_SuspendedToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_SuspendedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_SuspendedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_ReadyToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IGripperSkillType_StateMachine_ReadyToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Running = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_Running, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter_OutputParameter = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter_OutputParameter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Ready = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_Ready, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Halted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_Halted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Suspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_Suspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_HaltedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_HaltedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_ReadyToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_ReadyToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_RunningToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_RunningToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_RunningToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_RunningToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_RunningToSuspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_RunningToSuspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_SuspendedToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_SuspendedToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_SuspendedToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_SuspendedToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_SuspendedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_SuspendedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_ReadyToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.IMoveToAbsSkillType_StateMachine_ReadyToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the IGripperSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType = new ExpandedNodeId(Example.LinearAxisWithGripper.ObjectTypes.IGripperSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType = new ExpandedNodeId(Example.LinearAxisWithGripper.ObjectTypes.IMoveToAbsSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceUri = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceUri, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceVersion = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceVersion, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespacePublicationDate = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespacePublicationDate, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_IsNamespaceSubset = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_IsNamespaceSubset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_StaticNodeIdTypes = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_StaticNodeIdTypes, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_StaticNumericNodeIdRange = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_StaticNumericNodeIdRange, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_StaticStringNodeIdPattern = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_StaticStringNodeIdPattern, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Size = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Size, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Writable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Writable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_UserWritable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_UserWritable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_OpenCount = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_OpenCount, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_DefaultRolePermissions = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_DefaultRolePermissions, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_DefaultUserRolePermissions = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_DefaultUserRolePermissions, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_DefaultAccessRestrictions = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_DefaultAccessRestrictions, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_Identifier = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_Identifier, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_IsInstantiable Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_IsInstantiable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_IsInstantiable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_CurrentState = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_CurrentState, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_CurrentState_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_CurrentState_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_LastTransition_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_LastTransition_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Start_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_Start_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Start_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Start_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_Start_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Running_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_Running_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Ready_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_Ready_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Halted_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_Halted_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Suspended_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_Suspended_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_HaltedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_HaltedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_ReadyToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_RunningToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_RunningToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_RunningToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_RunningToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_RunningToSuspended_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_SuspendedToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_SuspendedToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_SuspendedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_ReadyToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IGripperSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce Variable.
        /// </summary>
        public static readonly ExpandedNodeId IGripperSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IGripperSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_Identifier = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_Identifier, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_IsInstantiable Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_IsInstantiable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_IsInstantiable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_CurrentState = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_CurrentState, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_CurrentState_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_CurrentState_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_LastTransition_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_LastTransition_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Start_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_Start_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Running_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_Running_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Ready_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_Ready_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Halted_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_Halted_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Suspended_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_Suspended_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_HaltedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_HaltedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_ReadyToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_RunningToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_RunningToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_RunningToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_RunningToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_RunningToSuspended_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_SuspendedToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_SuspendedToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_SuspendedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_ReadyToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.IMoveToAbsSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the ExampleLinearAxisWithGripperNamespaceMetadata component.
        /// </summary>
        public const string ExampleLinearAxisWithGripperNamespaceMetadata = "https://example.com/UA/Examples/LinearAxisWithGripper/";

        /// <summary>
        /// The BrowseName for the IGripperSkillType component.
        /// </summary>
        public const string IGripperSkillType = "IGripperSkillType";

        /// <summary>
        /// The BrowseName for the IMoveToAbsSkillType component.
        /// </summary>
        public const string IMoveToAbsSkillType = "IMoveToAbsSkillType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the ExampleLinearAxisWithGripper namespace (.NET code namespace is 'Example.LinearAxisWithGripper').
        /// </summary>
        public const string ExampleLinearAxisWithGripper = "https://example.com/UA/Examples/LinearAxisWithGripper/";

        /// <summary>
        /// The URI for the ExampleLinearAxisWithGripperXsd namespace (.NET code namespace is 'Example.LinearAxisWithGripper').
        /// </summary>
        public const string ExampleLinearAxisWithGripperXsd = "https://example.com/UA/Examples/LinearAxisWithGripper/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaSkills namespace (.NET code namespace is 'Opc.Ua.Skills').
        /// </summary>
        public const string OpcUaSkills = "http://opcfoundation.org/UA/Skills/";

        /// <summary>
        /// The URI for the OpcUaSkillsXsd namespace (.NET code namespace is 'Opc.Ua.Skills').
        /// </summary>
        public const string OpcUaSkillsXsd = "http://opcfoundation.org/UA/Skills/Types.xsd";
    }
    #endregion
}