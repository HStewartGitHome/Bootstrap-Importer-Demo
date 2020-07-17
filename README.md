---
title: Bootstrap Importer Extension Demo
---

Stewart Hyde

Introduction
============

This extension is to aid in moving visual components of Bootstrap related to
HTML over to Microsoft Blazor products and in Limited fashion to Razor Pages.
This extension is an idea in connection with a 3rd party product called
Bootstrap Studio but is not limited to just that product. In the extension has
limited support for non-bootstrap pages. The extension will create Razor page,
move some resources, include separate CSS files which are important. Embedded
scripts in the body of html appears not be allowed in Razor pages and thus are
removed.

The extension is available on Visual Studio Marketplace and currently only
available in binary form. Plans include the possibility of bringing the source
public, but I have included this GitHub as example of what it can do.

The following is example screen that is can be generated without any source code
modification.

![](media/9bfe47363697b0c6cd8f63835c8e9381.png)

The following is visual studio dialog with options for generating the necessary
code. Note this is not just limited to Bootstrap or Bootstrap Studio but results
may not compile especially dealing with scripts.

![](media/48115e2bf034b8dded7fc63b560ae346.png)

The following is a more detail document that includes instructions and more
examples on using the extension.

You can download the projects and Bootstrap Studio from
<https://bootstrapstudio.io/tutorials/>

I hope you enjoy this extension and it primary use to show what is possible with
attempts to isolated CSS in Blazor and even older Razor projects and to fill the
gap of visual interface using Bootstrap Studio.

Stewart Hyde
