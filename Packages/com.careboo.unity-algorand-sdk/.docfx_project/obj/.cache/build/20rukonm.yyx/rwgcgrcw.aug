﻿<!DOCTYPE html>
<!--[if IE]><![endif]-->
<html>
  
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <title>Struct SignProgramMultisigResponse
   </title>
    <meta name="viewport" content="width=device-width">
    <meta name="title" content="Struct SignProgramMultisigResponse
   ">
    <meta name="generator" content="docfx 2.56.6.0">
    
    <link rel="shortcut icon" href="../favicon.ico">
    <link rel="stylesheet" href="../styles/docfx.vendor.css">
    <link rel="stylesheet" href="../styles/docfx.css">
    <link rel="stylesheet" href="../styles/main.css">
    <meta property="docfx:navrel" content="../toc.html">
    <meta property="docfx:tocrel" content="toc.html">
    
    
    
  </head>
  <body data-spy="scroll" data-target="#affix" data-offset="120">
    <div id="wrapper">
      <header>
        
        <nav id="autocollapse" class="navbar navbar-inverse ng-scope" role="navigation">
          <div class="container">
            <div class="navbar-header">
              <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
              </button>
              
              <a class="navbar-brand" href="../index.html">
                <img id="logo" class="svg" src="../logo.svg" alt="">
              </a>
            </div>
            <div class="collapse navbar-collapse" id="navbar">
              <form class="navbar-form navbar-right" role="search" id="search">
                <div class="form-group">
                  <input type="text" class="form-control" id="search-query" placeholder="Search" autocomplete="off">
                </div>
              </form>
            </div>
          </div>
        </nav>
        
        <div class="subnav navbar navbar-default">
          <div class="container hide-when-search" id="breadcrumb">
            <ul class="breadcrumb">
              <li></li>
            </ul>
          </div>
        </div>
      </header>
      <div role="main" class="container body-content hide-when-search">
        
        <div class="sidenav hide-when-search">
          <a class="btn toc-toggle collapse" data-toggle="collapse" href="#sidetoggle" aria-expanded="false" aria-controls="sidetoggle">Show / Hide Table of Contents</a>
          <div class="sidetoggle collapse" id="sidetoggle">
            <div id="sidetoc"></div>
          </div>
        </div>
        <div class="article row grid-right">
          <div class="col-md-10">
            <article class="content wrap" id="_content" data-uid="AlgoSdk.SignProgramMultisigResponse">
  
  
  <h1 id="AlgoSdk_SignProgramMultisigResponse" data-uid="AlgoSdk.SignProgramMultisigResponse" class="text-break">Struct SignProgramMultisigResponse
  </h1>
  <div class="markdown level0 summary"></div>
  <div class="markdown level0 conceptual"></div>
  <div classs="implements">
    <h5>Implements</h5>
    <div><span class="xref">System.IEquatable</span>&lt;<a class="xref" href="AlgoSdk.SignProgramMultisigResponse.html">SignProgramMultisigResponse</a>&gt;</div>
  </div>
  <div class="inheritedMembers">
    <h5>Inherited Members</h5>
    <div>
      <span class="xref">System.ValueType.Equals(System.Object)</span>
    </div>
    <div>
      <span class="xref">System.ValueType.GetHashCode()</span>
    </div>
    <div>
      <span class="xref">System.ValueType.ToString()</span>
    </div>
    <div>
      <span class="xref">System.Object.Equals(System.Object, System.Object)</span>
    </div>
    <div>
      <span class="xref">System.Object.GetType()</span>
    </div>
    <div>
      <span class="xref">System.Object.ReferenceEquals(System.Object, System.Object)</span>
    </div>
  </div>
  <h6><strong>Namespace</strong>: <a class="xref" href="AlgoSdk.html">AlgoSdk</a></h6>
  <h6><strong>Assembly</strong>: CareBoo.AlgoSdk.dll</h6>
  <h5 id="AlgoSdk_SignProgramMultisigResponse_syntax">Syntax</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public struct SignProgramMultisigResponse : IEquatable&lt;SignProgramMultisigResponse&gt;</code></pre>
  </div>
  <h3 id="fields">Fields
  </h3>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/CareBoo/unity-algorand-sdk/new/jasonboukheir/issue#33/apiSpec/new?filename=AlgoSdk_SignProgramMultisigResponse_Error.md&amp;value=---%0Auid%3A%20AlgoSdk.SignProgramMultisigResponse.Error%0Asummary%3A%20'*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax'%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/CareBoo/unity-algorand-sdk/blob/jasonboukheir/issue#33/Packages/com.careboo.unity-algorand-sdk/CareBoo.AlgoSdk/AlgoApi/Kmd/Models/Signatures/SignProgramMultisigResponse.cs/#L13">View Source</a>
  </span>
  <h4 id="AlgoSdk_SignProgramMultisigResponse_Error" data-uid="AlgoSdk.SignProgramMultisigResponse.Error">Error</h4>
  <div class="markdown level1 summary"></div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">[AlgoApiField(&quot;error&quot;, null, false)]
public Optional&lt;bool&gt; Error</code></pre>
  </div>
  <h5 class="fieldValue">Field Value</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="AlgoSdk.Optional-1.html">Optional</a>&lt;<span class="xref">System.Boolean</span>&gt;</td>
        <td></td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/CareBoo/unity-algorand-sdk/new/jasonboukheir/issue#33/apiSpec/new?filename=AlgoSdk_SignProgramMultisigResponse_Message.md&amp;value=---%0Auid%3A%20AlgoSdk.SignProgramMultisigResponse.Message%0Asummary%3A%20'*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax'%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/CareBoo/unity-algorand-sdk/blob/jasonboukheir/issue#33/Packages/com.careboo.unity-algorand-sdk/CareBoo.AlgoSdk/AlgoApi/Kmd/Models/Signatures/SignProgramMultisigResponse.cs/#L16">View Source</a>
  </span>
  <h4 id="AlgoSdk_SignProgramMultisigResponse_Message" data-uid="AlgoSdk.SignProgramMultisigResponse.Message">Message</h4>
  <div class="markdown level1 summary"></div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">[AlgoApiField(&quot;message&quot;, null, false)]
public string Message</code></pre>
  </div>
  <h5 class="fieldValue">Field Value</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.String</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/CareBoo/unity-algorand-sdk/new/jasonboukheir/issue#33/apiSpec/new?filename=AlgoSdk_SignProgramMultisigResponse_SignedProgram.md&amp;value=---%0Auid%3A%20AlgoSdk.SignProgramMultisigResponse.SignedProgram%0Asummary%3A%20'*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax'%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/CareBoo/unity-algorand-sdk/blob/jasonboukheir/issue#33/Packages/com.careboo.unity-algorand-sdk/CareBoo.AlgoSdk/AlgoApi/Kmd/Models/Signatures/SignProgramMultisigResponse.cs/#L10">View Source</a>
  </span>
  <h4 id="AlgoSdk_SignProgramMultisigResponse_SignedProgram" data-uid="AlgoSdk.SignProgramMultisigResponse.SignedProgram">SignedProgram</h4>
  <div class="markdown level1 summary"></div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">[AlgoApiField(&quot;multisig&quot;, null, false)]
public byte[] SignedProgram</code></pre>
  </div>
  <h5 class="fieldValue">Field Value</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.Byte</span>[]</td>
        <td></td>
      </tr>
    </tbody>
  </table>
  <h3 id="methods">Methods
  </h3>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/CareBoo/unity-algorand-sdk/new/jasonboukheir/issue#33/apiSpec/new?filename=AlgoSdk_SignProgramMultisigResponse_Equals_AlgoSdk_SignProgramMultisigResponse_.md&amp;value=---%0Auid%3A%20AlgoSdk.SignProgramMultisigResponse.Equals(AlgoSdk.SignProgramMultisigResponse)%0Asummary%3A%20'*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax'%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/CareBoo/unity-algorand-sdk/blob/jasonboukheir/issue#33/Packages/com.careboo.unity-algorand-sdk/CareBoo.AlgoSdk/AlgoApi/Kmd/Models/Signatures/SignProgramMultisigResponse.cs/#L18">View Source</a>
  </span>
  <a id="AlgoSdk_SignProgramMultisigResponse_Equals_" data-uid="AlgoSdk.SignProgramMultisigResponse.Equals*"></a>
  <h4 id="AlgoSdk_SignProgramMultisigResponse_Equals_AlgoSdk_SignProgramMultisigResponse_" data-uid="AlgoSdk.SignProgramMultisigResponse.Equals(AlgoSdk.SignProgramMultisigResponse)">Equals(SignProgramMultisigResponse)</h4>
  <div class="markdown level1 summary"></div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public bool Equals(SignProgramMultisigResponse other)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="AlgoSdk.SignProgramMultisigResponse.html">SignProgramMultisigResponse</a></td>
        <td><span class="parametername">other</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.Boolean</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>
  <h3 id="implements">Implements</h3>
  <div>
      <span class="xref">System.IEquatable&lt;T&gt;</span>
  </div>
</article>
          </div>
          
          <div class="hidden-sm col-md-2" role="complementary">
            <div class="sideaffix">
              <div class="contribution">
                <ul class="nav">
                  <li>
                    <a href="https://github.com/CareBoo/unity-algorand-sdk/new/jasonboukheir/issue#33/apiSpec/new?filename=AlgoSdk_SignProgramMultisigResponse.md&amp;value=---%0Auid%3A%20AlgoSdk.SignProgramMultisigResponse%0Asummary%3A%20'*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax'%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A" class="contribution-link">Improve this Doc</a>
                  </li>
                  <li>
                    <a href="https://github.com/CareBoo/unity-algorand-sdk/blob/jasonboukheir/issue#33/Packages/com.careboo.unity-algorand-sdk/CareBoo.AlgoSdk/AlgoApi/Kmd/Models/Signatures/SignProgramMultisigResponse.cs/#L5" class="contribution-link">View Source</a>
                  </li>
                </ul>
              </div>
              <nav class="bs-docs-sidebar hidden-print hidden-xs hidden-sm affix" id="affix">
                <h5>In This Article</h5>
                <div></div>
              </nav>
            </div>
          </div>
        </div>
      </div>
      
      <footer>
        <div class="grad-bottom"></div>
        <div class="footer">
          <div class="container">
            <span class="pull-right">
              <a href="#top">Back to top</a>
            </span>
            
            <span>Generated by <strong>DocFX</strong></span>
          </div>
        </div>
      </footer>
    </div>
    
    <script type="text/javascript" src="../styles/docfx.vendor.js"></script>
    <script type="text/javascript" src="../styles/docfx.js"></script>
    <script type="text/javascript" src="../styles/main.js"></script>
  </body>
</html>
