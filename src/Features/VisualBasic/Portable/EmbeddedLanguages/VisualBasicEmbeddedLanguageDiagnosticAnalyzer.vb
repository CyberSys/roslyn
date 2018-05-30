﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports Microsoft.CodeAnalysis.Diagnostics
Imports Microsoft.CodeAnalysis.EmbeddedLanguages
Imports Microsoft.CodeAnalysis.VisualBasic.EmbeddedLanguages.LanguageServices

Namespace Microsoft.CodeAnalysis.VisualBasic.EmbeddedLanguages
    <DiagnosticAnalyzer(LanguageNames.VisualBasic)>
    Friend Class VisualBasicEmbeddedLanguageDiagnosticAnalyzer
        Inherits AbstractEmbeddedLanguageDiagnosticAnalyzer

        Public Sub New()
            MyBase.New(VisualBasicEmbeddedLanguageProvider.Instance)
        End Sub
    End Class
End Namespace
