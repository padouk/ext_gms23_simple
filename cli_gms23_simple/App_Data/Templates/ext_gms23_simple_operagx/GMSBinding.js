//Generated File
{{#each ExternFunctions}}
{{Name}} = function ({{#each Arguments}}{{Name}}{{/each}}) { return ccall('{{Name}}', {{#if IsReturnTypeNumber}}'number'{{else}}'string'{{/if}}, [{{#each Arguments}}{{#if IsTypeNumber}}'number'{{else if IsTypeBuffer}}'array'{{else}}'string'{{/if}}{{#unless @last}}, {{/unless}}{{/each}}], [{{#each Arguments}}{{#if IsTypeNumber}}{{Name}}{{else if IsTypeBuffer}}new Int8Array({{Name}}){{else}}{{Name}}{{/if}}{{#unless @last}}, {{/unless}}{{/each}}]); }
{{/each}}