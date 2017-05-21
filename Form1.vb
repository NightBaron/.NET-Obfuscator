Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.CompilerServices
Imports Mono.Cecil
Imports Mono.Cecil.Cil
Imports Mono.Collections.Generic

Public Class Form1
    Private r As Random
    Private list As List(Of TypeDefinition)
    Private list2 As List(Of MethodDefinition)
    Public Function junkmethods(reversed As AssemblyDefinition) As AssemblyDefinition
        Try
            Dim enumerator As Collection(Of ModuleDefinition).Enumerator = reversed.Modules.GetEnumerator()
            While enumerator.MoveNext()
                Dim current As ModuleDefinition = enumerator.Current
                Dim num As Integer = 0
                Dim arg_6A_0 As Integer
                Dim num2 As Integer
                Do
                    Dim item As TypeDefinition = New TypeDefinition(reversed.Name.Name, "PornHub" + Conversions.ToString(r.[Next](100, 999)), TypeAttributes.NotPublic)
                    current.Types.Add(item)
                    num += 1
                    arg_6A_0 = num
                    num2 = 9
                Loop While arg_6A_0 <= num2
                Try
                    Dim enumerator2 As Collection(Of TypeDefinition).Enumerator = current.Types.GetEnumerator()
                    While enumerator2.MoveNext()
                        Dim current2 As TypeDefinition = enumerator2.Current
                        Dim flag As Boolean = ShouldRename(current2)
                        If flag Then
                            Dim num3 As Integer = 0
                            Dim arg_12E_0 As Integer
                            Do
                                Dim methodDefinition As MethodDefinition = New MethodDefinition("PornHub" + Conversions.ToString(r.[Next](100, 999)), MethodAttributes.[Public], reversed.MainModule.Import(GetRandomType()))
                                methodDefinition.Body.Instructions.Add(New Instruction(OpCodes.Ldarg_3, Nothing))
                                methodDefinition.Body.Instructions.Add(New Instruction(OpCodes.Ret, Nothing))
                                current2.Methods.Add(methodDefinition)
                                num3 += 1
                                arg_12E_0 = num3
                                num2 = 9
                            Loop While arg_12E_0 <= num2
                        End If
                    End While
                Finally
                    Dim enumerator2 As Collection(Of TypeDefinition).Enumerator
                    CType(enumerator2, IDisposable).Dispose()
                End Try
            End While
        Finally
            Dim enumerator As Collection(Of ModuleDefinition).Enumerator
            CType(enumerator, IDisposable).Dispose()
        End Try
        Return reversed
    End Function

    Public Function ShouldRename(m As MethodDefinition) As Boolean
        Dim flag As Boolean = Operators.CompareString(m.Name, "InitializeComponent", False) = 0
        Dim result As Boolean
        If flag Then
            result = False
        Else
            Dim left As String = m.Name.ToLower()
            flag = (Operators.CompareString(left, "<Module>", False) <> 0 AndAlso Operators.CompareString(left, ".ctor", False) <> 0 AndAlso Operators.CompareString(left, ".cctor", False) <> 0 AndAlso Operators.CompareString(left, "new", False) <> 0 AndAlso Operators.CompareString(left, "dispose", False) <> 0 AndAlso Operators.CompareString(left, "finalize", False) <> 0 AndAlso Not m.IsConstructor AndAlso Not m.IsRuntime AndAlso Not m.IsRuntimeSpecialName AndAlso Not m.IsSpecialName AndAlso Not m.IsVirtual AndAlso Not m.IsAbstract AndAlso m.[Overrides].Count <= 0 AndAlso Not m.Name.StartsWith("<") AndAlso Not m.IsPInvokeImpl)
            result = flag
        End If
        Return result
    End Function

    Public Sub SetN(asm As AssemblyDefinition)
        Try
            Dim enumerator As Collection(Of TypeDefinition).Enumerator = asm.MainModule.Types.GetEnumerator()
            While enumerator.MoveNext()
                Dim current As TypeDefinition = enumerator.Current
                Dim mtname As Boolean = Not current.Name.StartsWith("PornHub")
                If mtname Then
                    list.Add(current)
                End If
            End While
        Finally
            Dim enumerator As Collection(Of TypeDefinition).Enumerator
            CType(enumerator, IDisposable).Dispose()
        End Try
        Try
            Dim enumerator2 As List(Of TypeDefinition).Enumerator = list.GetEnumerator()
            While enumerator2.MoveNext()
                Dim current2 As TypeDefinition = enumerator2.Current
                Try
                    Dim enumerator3 As Collection(Of MethodDefinition).Enumerator = current2.Methods.GetEnumerator()
                    While enumerator3.MoveNext()
                        Dim current3 As MethodDefinition = enumerator3.Current
                        Dim flag As Boolean = Not current3.Name.StartsWith("PornHub")
                        If flag Then
                            list2.Add(current3)
                        End If
                    End While
                Finally
                    Dim enumerator3 As Collection(Of MethodDefinition).Enumerator
                    CType(enumerator3, IDisposable).Dispose()
                End Try
            End While
        Finally
            Dim enumerator2 As List(Of TypeDefinition).Enumerator
            CType(enumerator2, IDisposable).Dispose()
        End Try
    End Sub


    Public Function ShouldRename(c As TypeDefinition) As Boolean
        Return Operators.CompareString(c.Name, "<Module>", False) <> 0 AndAlso Not c.IsRuntimeSpecialName AndAlso Not c.IsSpecialName AndAlso Not c.Name.Contains("Resources") AndAlso Not c.Name.StartsWith("<") AndAlso Not c.Name.Contains("__") AndAlso Not c.IsEnum
    End Function

    Public Function ControlFlow(reversed As AssemblyDefinition) As AssemblyDefinition
        VBMath.Randomize()
        Try
            Dim enumerator As Collection(Of ModuleDefinition).Enumerator = reversed.Modules.GetEnumerator()
            While enumerator.MoveNext()
                Dim current As ModuleDefinition = enumerator.Current
                Try
                    Dim enumerator2 As Collection(Of TypeDefinition).Enumerator = current.Types.GetEnumerator()
                    While enumerator2.MoveNext()
                        Dim current2 As TypeDefinition = enumerator2.Current
                        Try
                            Dim enumerator3 As Collection(Of MethodDefinition).Enumerator = current2.Methods.GetEnumerator()
                            While enumerator3.MoveNext()
                                Dim current3 As MethodDefinition = enumerator3.Current
                                Dim flag As Boolean = current3.Body IsNot Nothing
                                If flag Then
                                    current3.Body.Instructions.Add(New Instruction(GetRndCrap(), Nothing))
                                    current3.Body.Instructions.Add(New Instruction(OpCodes.Ret, Nothing))
                                End If
                            End While
                        Finally
                            Dim enumerator3 As Collection(Of MethodDefinition).Enumerator
                            CType(enumerator3, IDisposable).Dispose()
                        End Try
                    End While
                Finally
                    Dim enumerator2 As Collection(Of TypeDefinition).Enumerator
                    CType(enumerator2, IDisposable).Dispose()
                End Try
            End While
        Finally
            Dim enumerator As Collection(Of ModuleDefinition).Enumerator
            CType(enumerator, IDisposable).Dispose()
        End Try
        Return reversed
    End Function
    Public Function GetRndCrap() As OpCode
        Dim result As OpCode
        Select Case r.[Next](1, 5)
            Case 1
                result = OpCodes.Add
            Case 2
                result = OpCodes.Div
            Case 3
                result = OpCodes.[Xor]
            Case 4
                result = OpCodes.Mul
        End Select
        Return result
    End Function

    Public Function GetRandomType() As Type
        Dim typeFromHandle As Type
        Select Case r.[Next](0, 10)
            Case 0
                typeFromHandle = GetType(Type)
            Case 1
                typeFromHandle = GetType(Void)
            Case 2
                typeFromHandle = GetType(Form)
            Case 3
                typeFromHandle = GetType(Reflection.Assembly)
            Case 4
                typeFromHandle = GetType(Byte())
            Case 5
                typeFromHandle = GetType(Char)
            Case 6
                typeFromHandle = GetType(AssemblyDefinition)
            Case 7
                typeFromHandle = GetType(Button)
            Case 8
                typeFromHandle = GetType(Boolean)
            Case 9
                typeFromHandle = GetType(Encoding)
            Case 10
                typeFromHandle = GetType(Clipboard)
            Case Else
                typeFromHandle = GetType(Form)
        End Select
        Return typeFromHandle
    End Function

    Public Function StringEncryptor(a As AssemblyDefinition) As AssemblyDefinition
        Try
            Dim enumerator As Collection(Of TypeDefinition).Enumerator = a.MainModule.Types.GetEnumerator()
            While enumerator.MoveNext()
                Dim current As TypeDefinition = enumerator.Current
                Dim flag As Boolean = Operators.CompareString(current.Name, "Decrypt", False) = 0
                If flag Then
                End If
            End While
        Finally
            Dim enumerator As Collection(Of TypeDefinition).Enumerator
            CType(enumerator, IDisposable).Dispose()
        End Try
        Dim typeDefinition As TypeDefinition = New TypeDefinition(a.Name.Name, "Decode", Mono.Cecil.TypeAttributes.[Public])
        Dim typeReference As TypeReference = a.MainModule.Import(GetType(String))
        Dim methodDefinition As MethodDefinition = New MethodDefinition("DecodeMe", Mono.Cecil.MethodAttributes.FamANDAssem Or MethodAttributes.Family Or MethodAttributes.[Static], typeReference)
        methodDefinition.Body.Variables.Add(New VariableDefinition(typeReference))
        Dim iLProcessor As ILProcessor = methodDefinition.Body.GetILProcessor()
        iLProcessor.Emit(OpCodes.[Call], a.MainModule.Import(GetType(Encoding).GetProperty("ASCII").GetGetMethod()))
        iLProcessor.Emit(OpCodes.Ldarg_0)
        iLProcessor.Emit(OpCodes.[Call], a.MainModule.Import(GetType(Convert).GetMethod("FromBase64String")))
        iLProcessor.Emit(OpCodes.Callvirt, a.MainModule.Import(GetType(Encoding).GetMethod("GetString", New Type() {GetType(Byte())})))
        iLProcessor.Emit(OpCodes.Stloc_0)
        iLProcessor.Emit(OpCodes.Ldloc_0)
        iLProcessor.Emit(OpCodes.Ret)
        methodDefinition.Parameters.Add(New ParameterDefinition("str", ParameterAttributes.HasDefault, typeReference))
        ' The following expression was wrapped in a checked-statement
        Try
            Dim enumerator2 As Collection(Of TypeDefinition).Enumerator = a.MainModule.Types.GetEnumerator()
            While enumerator2.MoveNext()
                Dim current2 As TypeDefinition = enumerator2.Current
                Dim flag As Boolean = ShouldRename(current2)
                If flag Then
                    methodDefinition.DeclaringType = current2
                    current2.Methods.Add(methodDefinition)
                End If
                Dim arg_204_0 As Integer = 0
                Dim num As Integer = current2.Methods.Count - 1
                Dim num2 As Integer = arg_204_0
                While True
                    Dim arg_460_0 As Integer = num2
                    Dim num3 As Integer = num
                    If arg_460_0 > num3 Then
                        Exit While
                    End If
                    flag = (current2.Methods(num2).Name.Length = 7)
                    If Not flag Then
                        GoTo IL_285
                    End If
                    Dim flag2 As Boolean = Operators.CompareString(current2.Methods(num2).Name.Substring(0, 3), "DE_", False) = 0 AndAlso Versioned.IsNumeric(current2.Methods(num2).Name.Substring(3, 5))
                    If Not flag2 Then
                        GoTo IL_285
                    End If
IL_451:
                    num2 += 1
                    Continue While
IL_285:
                    flag2 = ShouldRename(current2.Methods(num2))
                    If flag2 Then
                        Dim arg_2C5_0 As Integer = 0
                        Dim num4 As Integer = current2.Methods(num2).Body.Instructions.Count - 1
                        Dim num5 As Integer = arg_2C5_0
                        While True
                            Dim arg_44B_0 As Integer = num5
                            num3 = num4
                            If arg_44B_0 > num3 Then
                                Exit While
                            End If
                            flag = (current2.Methods(num2).Body.Instructions(num5).OpCode.Code = Code.Ldstr)
                            If flag Then
                                Dim flag3 As Boolean = Not IsBase64(Conversions.ToString(current2.Methods(num2).Body.Instructions(num5).Operand))
                                If flag3 Then
                                    Dim s As String = Conversions.ToString(current2.Methods(num2).Body.Instructions(num5).Operand)
                                    Dim value As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(s))
                                    Dim methodDefinition2 As MethodDefinition = New MethodDefinition("DE_" + Conversions.ToString(r.[Next](10000, 99999)), MethodAttributes.FamANDAssem Or MethodAttributes.Family Or MethodAttributes.[Static], typeReference)
                                    methodDefinition2.Body.Variables.Add(New VariableDefinition(typeReference))
                                    Dim iLProcessor2 As ILProcessor = methodDefinition2.Body.GetILProcessor()
                                    iLProcessor2.Emit(OpCodes.Ldstr, value)
                                    iLProcessor2.Emit(OpCodes.[Call], methodDefinition)
                                    iLProcessor2.Emit(OpCodes.Ret)
                                    current2.Methods.Add(methodDefinition2)
                                    current2.Methods(num2).Body.Instructions(num5) = New Instruction(OpCodes.[Call], methodDefinition2)
                                End If
                            End If
                            num5 += 1
                        End While
                    End If
                    GoTo IL_451
                End While
            End While
        Finally
            Dim enumerator2 As Collection(Of TypeDefinition).Enumerator
            CType(enumerator2, IDisposable).Dispose()
        End Try
        Return a
    End Function

    Public Function IsBase64(b As String) As Boolean
        Dim regex As Regex = New Regex("^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{4}|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)$")
        Return regex.IsMatch(b)
    End Function
    Private Sub import_btn_Click(sender As Object, e As EventArgs) Handles import_btn.Click
        Dim assembly As Boolean = OpenFileDialog1.ShowDialog() = DialogResult.OK
        If assembly Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private renamearray As String()
    Private Sub obfuscate_btn_Click(sender As Object, e As EventArgs) Handles obfuscate_btn.Click
        Dim protect As Boolean = Not ildasm.Checked AndAlso Not tamper.Checked AndAlso Not ctrlflow.Checked AndAlso Not encodestr.Checked AndAlso Not renames.Checked AndAlso Not junkmethod.Checked AndAlso Not signature.Checked
        If protect Then
            MsgBox("Please choose at least one option to protect your assembly.", MsgBoxStyle.OkOnly, Nothing)
        Else
            renamearray = My.Resources.eng.Split(New Char() {vbCr})
        End If

        Dim assembly As Boolean = (Operators.CompareString(TextBox1.Text, "", False) = 0)
        If assembly Then
            MsgBox("Assembly not found!", MsgBoxStyle.OkOnly, Nothing)
        Else
            Dim assemblyDefinition As AssemblyDefinition = AssemblyDefinition.ReadAssembly(TextBox1.Text)
            If encodestr.Checked = True Then
                assemblyDefinition = StringEncryptor(assemblyDefinition)
            End If
            If ctrlflow.Checked = True Then
                assemblyDefinition = ControlFlow(assemblyDefinition)
            End If
            If junkmethod.Checked = True Then
                assemblyDefinition = junkmethods(assemblyDefinition)
            End If
            If renames.Checked = True Then
                assemblyDefinition = Rename(assemblyDefinition)
            End If
            assemblyDefinition = FixRes(assemblyDefinition)
            If signature.Checked = True Then
                assemblyDefinition = AddSignature(assemblyDefinition)
            End If
            If ildasm.Checked = True Then
                assemblyDefinition = SuppressIlDasm(assemblyDefinition)
            End If
            If tamper.Checked = True Then
                'assemblyDefinition = AddSignature(assemblyDefinition)
            End If

            Dim extension As String = Path.GetExtension(TextBox1.Text)
            assemblyDefinition.Write(TextBox1.Text.Replace(extension, "") + "_Obfuscated" + extension)
            Interaction.MsgBox("Obfuscated!", MsgBoxStyle.OkOnly, Nothing)
        End If

    End Sub

    Public Function SuppressIlDasm(a As AssemblyDefinition) As AssemblyDefinition
        Dim constructor As MethodReference = a.MainModule.Import(GetType(SuppressIldasmAttribute).GetConstructor(New Type(-1) {}))
        a.CustomAttributes.Add(New CustomAttribute(constructor))
        Return a
    End Function

    Public Function FixRes(reversed As AssemblyDefinition) As AssemblyDefinition
        Try
            Dim enumerator As Collection(Of ModuleDefinition).Enumerator = reversed.Modules.GetEnumerator()
            While enumerator.MoveNext()
                Dim current As ModuleDefinition = enumerator.Current
                Try
                    Dim enumerator2 As Collection(Of Resource).Enumerator = current.Resources.GetEnumerator()
                    While enumerator2.MoveNext()
                        Dim current2 As Resource = enumerator2.Current
                        Dim flag As Boolean = current2.Name.Contains("My.Resources")
                        If flag Then
                            current2.Name = current2.Name.Replace("My.Resources.", "")
                        End If
                    End While
                Finally
                    Dim enumerator2 As Collection(Of Resource).Enumerator
                    CType(enumerator2, IDisposable).Dispose()
                End Try
            End While
        Finally
            Dim enumerator As Collection(Of ModuleDefinition).Enumerator
            CType(enumerator, IDisposable).Dispose()
        End Try
        Return reversed
    End Function

    Public Function AddSignature(reversed As AssemblyDefinition) As AssemblyDefinition
        Try
            Dim enumerator As Collection(Of ModuleDefinition).Enumerator = reversed.Modules().GetEnumerator()
            While enumerator.MoveNext()
                Dim current As ModuleDefinition = enumerator.Current()
                current.Types().Add(New TypeDefinition("DotNET.Obfuscator", "ByNightBaron", 0))
            End While
        Finally
            Dim enumerator As Collection(Of ModuleDefinition).Enumerator
            enumerator.Dispose()
        End Try
        Return reversed
    End Function

    Public Function randomname(lengh As Integer) As String
        VBMath.Randomize()
        Dim text As String = ""
        text = renamearray(r.[Next](0, renamearray.Length)).Trim().Replace("'", "")
        Return text
    End Function

    Public Function Rename(reversed As AssemblyDefinition) As AssemblyDefinition
        VBMath.Randomize()
        Try
            Dim enumerator As Collection(Of ModuleDefinition).Enumerator = reversed.Modules.GetEnumerator()
            While enumerator.MoveNext()
                Dim current As ModuleDefinition = enumerator.Current
                Try
                    Dim enumerator2 As Collection(Of TypeDefinition).Enumerator = current.Types.GetEnumerator()
                    While enumerator2.MoveNext()
                        Dim current2 As TypeDefinition = enumerator2.Current
                        Dim flag As Boolean = ShouldRename(current2)
                        If flag Then
                            Dim name As String = current2.Name
                            current2.Name = randomname(r.[Next](20, 50))
                            Try
                                Dim enumerator3 As Collection(Of Resource).Enumerator = current.Resources.GetEnumerator()
                                While enumerator3.MoveNext()
                                    Dim current3 As Resource = enumerator3.Current
                                    ' The following expression was wrapped in a checked-expression
                                    flag = (current3.Name.Contains(name) AndAlso Operators.CompareString(current3.Name.Substring(current3.Name.LastIndexOf(name) - 1, 1), ".", False) = 0)
                                    If flag Then
                                        current3.Name = current2.FullName + ".resources"
                                    End If
                                End While
                            Finally
                                Dim enumerator3 As Collection(Of Resource).Enumerator
                                CType(enumerator3, IDisposable).Dispose()
                            End Try
                        End If
                        Try
                            Dim enumerator4 As Collection(Of MethodDefinition).Enumerator = current2.Methods.GetEnumerator()
                            While enumerator4.MoveNext()
                                Dim current4 As MethodDefinition = enumerator4.Current
                                flag = ShouldRename(current4)
                                If flag Then
                                    current4.Name = randomname(r.[Next](30, 50))
                                End If
                                Try
                                    Dim enumerator5 As Collection(Of ParameterDefinition).Enumerator = current4.Parameters.GetEnumerator()
                                    While enumerator5.MoveNext()
                                        Dim current5 As ParameterDefinition = enumerator5.Current
                                        current5.Name = randomname(r.[Next](30, 50))
                                    End While
                                Finally
                                    Dim enumerator5 As Collection(Of ParameterDefinition).Enumerator
                                    CType(enumerator5, IDisposable).Dispose()
                                End Try
                            End While
                        Finally
                            Dim enumerator4 As Collection(Of MethodDefinition).Enumerator
                            CType(enumerator4, IDisposable).Dispose()
                        End Try
                    End While
                Finally
                    Dim enumerator2 As Collection(Of TypeDefinition).Enumerator
                    CType(enumerator2, IDisposable).Dispose()
                End Try
            End While
        Finally
            Dim enumerator As Collection(Of ModuleDefinition).Enumerator
            CType(enumerator, IDisposable).Dispose()
        End Try
        Return reversed
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        r = New Random()
        list = New List(Of TypeDefinition)()
        list2 = New List(Of MethodDefinition)()
    End Sub
End Class
