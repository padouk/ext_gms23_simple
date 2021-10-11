{{#each ExternFunctions}}
function {{../ExtensionName}}_{{Name}}({{#each Arguments}}{{Name}}{{#if DefaultValue}}={{{DefaultValue}}}{{/if}}{{#unless @last}},{{/unless}}{{/each}}) { gml_pragma("forceinline"); return _ext_{{../ExtensionName}}_{{Name}}({{#each Arguments}}{{Name}}{{#unless @last}},{{/unless}}{{/each}}); }
{{/each}}
