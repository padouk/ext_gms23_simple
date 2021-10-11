{
  "optionsFile": "options.json",
  "options": [],
  "exportToGame": true,
  "supportedTargets": -1,
  "extensionVersion": "0.0.1",
  "packageId": "",
  "productId": "",
  "author": "",
  "date": "2021-10-11T11:13:05.4867866-04:00",
  "license": "",
  "description": "",
  "helpfile": "",
  "iosProps": false,
  "tvosProps": false,
  "androidProps": false,
  "installdir": "",
  "files": [
    {"filename":"ext_{{ExtensionName}}.gml","origname":"","init":"","final":"","kind":2,"uncompress":false,"functions":[],"constants":[],"ProxyFiles":[],"copyToTargets":-1,"order":[],"resourceVersion":"1.0","name":"","tags":[],"resourceType":"GMExtensionFile",},
    {"filename":"ext_{{ExtensionName}}_html5.js","origname":"","init":"","final":"","kind":5,"uncompress":false,"functions":[
      {{#each ExternFunctions}}
        {"externalName":"{{Name}}","kind":1,"help":"","hidden":false,"returnType":{{#if IsReturnTypeNumber}}2{{else}}1{{/if}},"argCount":0,"args":[{{#each Arguments}}{{#if IsTypeNumber}}2{{else}}1{{/if}}{{#unless @last}}, {{/unless}}{{/each}}],"resourceVersion":"1.0","name":"_ext_{{../ExtensionName}}_{{Name}}","tags":[],"resourceType":"GMExtensionFunction",}{{#unless @last}},{{/unless}}
      {{/each}}
    ],"constants":[],"ProxyFiles":[],"copyToTargets":32,"order":[],"resourceVersion":"1.0","name":"","tags":[],"resourceType":"GMExtensionFile",},
    {"filename":"ext_{{ExtensionName}}_macos64.dylib","origname":"","init":"","final":"","kind":1,"uncompress":false,"functions":[
      {{#each ExternFunctions}}
        {"externalName":"{{Name}}","kind":1,"help":"","hidden":false,"returnType":{{#if IsReturnTypeNumber}}2{{else}}1{{/if}},"argCount":0,"args":[{{#each Arguments}}{{#if IsTypeNumber}}2{{else}}1{{/if}}{{#unless @last}}, {{/unless}}{{/each}}],"resourceVersion":"1.0","name":"_ext_{{../ExtensionName}}_{{Name}}","tags":[],"resourceType":"GMExtensionFunction",}{{#unless @last}},{{/unless}}
      {{/each}}
    ],"constants":[],"ProxyFiles":[],"copyToTargets":2,"order":[],"resourceVersion":"1.0","name":"","tags":[],"resourceType":"GMExtensionFile",},
    {"filename":"ext_{{ExtensionName}}_win64.dll","origname":"","init":"","final":"","kind":1,"uncompress":false,"functions":[
      {{#each ExternFunctions}}
        {"externalName":"{{Name}}","kind":1,"help":"","hidden":false,"returnType":{{#if IsReturnTypeNumber}}2{{else}}1{{/if}},"argCount":0,"args":[{{#each Arguments}}{{#if IsTypeNumber}}2{{else}}1{{/if}}{{#unless @last}}, {{/unless}}{{/each}}],"resourceVersion":"1.0","name":"_ext_{{../ExtensionName}}_{{Name}}","tags":[],"resourceType":"GMExtensionFunction",}{{#unless @last}},{{/unless}}
      {{/each}}
    ],"constants":[],"ProxyFiles":[],"copyToTargets":64,"order":[],"resourceVersion":"1.0","name":"","tags":[],"resourceType":"GMExtensionFile",},
    {"filename":"ext_{{ExtensionName}}_win32.dll","origname":"","init":"","final":"","kind":1,"uncompress":false,"functions":[
      {{#each ExternFunctions}}
        {"externalName":"{{Name}}","kind":1,"help":"","hidden":false,"returnType":{{#if IsReturnTypeNumber}}2{{else}}1{{/if}},"argCount":0,"args":[{{#each Arguments}}{{#if IsTypeNumber}}2{{else}}1{{/if}}{{#unless @last}}, {{/unless}}{{/each}}],"resourceVersion":"1.0","name":"_ext_{{../ExtensionName}}_{{Name}}","tags":[],"resourceType":"GMExtensionFunction",}{{#unless @last}},{{/unless}}
      {{/each}}
    ],"constants":[],"ProxyFiles":[],"copyToTargets":0,"order":[],"resourceVersion":"1.0","name":"","tags":[],"resourceType":"GMExtensionFile",},
    {"filename":"ext_{{ExtensionName}}_ubuntu64.so","origname":"","init":"","final":"","kind":1,"uncompress":false,"functions":[
      {{#each ExternFunctions}}
        {"externalName":"{{Name}}","kind":1,"help":"","hidden":false,"returnType":{{#if IsReturnTypeNumber}}2{{else}}1{{/if}},"argCount":0,"args":[{{#each Arguments}}{{#if IsTypeNumber}}2{{else}}1{{/if}}{{#unless @last}}, {{/unless}}{{/each}}],"resourceVersion":"1.0","name":"_ext_{{../ExtensionName}}_{{Name}}","tags":[],"resourceType":"GMExtensionFunction",}{{#unless @last}},{{/unless}}
      {{/each}}
    ],"constants":[],"ProxyFiles":[],"copyToTargets":128,"order":[],"resourceVersion":"1.0","name":"","tags":[],"resourceType":"GMExtensionFile",},
  ],
  "classname": "",
  "tvosclassname": null,
  "tvosdelegatename": null,
  "iosdelegatename": "",
  "androidclassname": "",
  "sourcedir": "",
  "androidsourcedir": "",
  "macsourcedir": "",
  "maccompilerflags": "",
  "tvosmaccompilerflags": "",
  "maclinkerflags": "",
  "tvosmaclinkerflags": "",
  "iosplistinject": "",
  "tvosplistinject": "",
  "androidinject": "",
  "androidmanifestinject": "",
  "androidactivityinject": "",
  "gradleinject": "",
  "androidcodeinjection": "",
  "hasConvertedCodeInjection": false,
  "ioscodeinjection": "",
  "tvoscodeinjection": "",
  "iosSystemFrameworkEntries": [],
  "tvosSystemFrameworkEntries": [],
  "iosThirdPartyFrameworkEntries": [],
  "tvosThirdPartyFrameworkEntries": [],
  "IncludedResources": [],
  "androidPermissions": [],
  "copyToTargets": -1,
  "iosCocoaPods": "",
  "tvosCocoaPods": "",
  "iosCocoaPodDependencies": "",
  "tvosCocoaPodDependencies": "",
  "parent": {
    "name": "_interop",
    "path": "folders/Extensions/padouk.ca/ext_{{ExtensionName}}/_interop.yy",
  },
  "resourceVersion": "1.2",
  "name": "ext_{{ExtensionName}}",
  "tags": [],
  "resourceType": "GMExtension",
}