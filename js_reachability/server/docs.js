const path = require('node:path');

// swagger-ui-dist is only located with require.resolve, to serve its static files
module.exports.docsPath = () => path.dirname(require.resolve('swagger-ui-dist/package.json'));
