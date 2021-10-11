//Generated File
{{#each ExternFunctions}}
{{Name}} = cwrap('{{Name}}', {{#if IsReturnTypeNumber}}'number'{{else}}'string'{{/if}}, [{{#each Arguments}}{{#if IsTypeNumber}}'number'{{else}}'string'{{/if}}{{#unless @last}}, {{/unless}}{{/each}}]);
{{/each}}