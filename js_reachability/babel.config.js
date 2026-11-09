// Function config: depcheck had to run it to read it
module.exports = (api) => {
  api.cache(true);
  return {
    presets: [['@babel/env', { targets: { node: 'current' } }]],
    plugins: ['styled-components'],
  };
};
