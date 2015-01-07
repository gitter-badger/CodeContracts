// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Diagnostics.Contracts;

namespace System.Security.Policy
{

  public class FileCodeGroup
  {

    extern public string PermissionSetName
    {
      get;
    }

    extern public string AttributeString
    {
      get;
    }

    extern public string MergeLogic
    {
      get;
    }

    public CodeGroup Copy()
    {

      return default(CodeGroup);
    }
    public CodeGroup ResolveMatchingCodeGroups(Evidence evidence)
    {
      Contract.Requires(evidence != null);

      return default(CodeGroup);
    }
    public PolicyStatement Resolve(Evidence evidence)
    {
      Contract.Requires(evidence != null);

      return default(PolicyStatement);
    }
    public FileCodeGroup(IMembershipCondition membershipCondition, System.Security.Permissions.FileIOPermissionAccess access)
    {
      return default(FileCodeGroup);
    }
  }
}