// Builds the nuxt server bundle. @nuxt/nitro-server uses nitropack only from its .mjs files
const { bundle } = require('@nuxt/nitro-server');

module.exports = (nuxt) => bundle(nuxt);
