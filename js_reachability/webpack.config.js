const path = require('node:path');

// webpack 1 style config: loaders by their short names
module.exports = {
  entry: './client/index.js',
  output: { path: path.resolve(__dirname, 'dist'), filename: 'bundle.js' },
  module: {
    loaders: [
      { test: /\.css$/, loader: 'style!css' },
    ],
  },
};
