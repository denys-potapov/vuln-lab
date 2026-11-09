# vuln-lab

`dotnet/` is a minimal .NET console app used to test reachability analysis for vulnerable dependencies. It references two packages with known CVEs: `Newtonsoft.Json` 12.0.1 (GHSA-5crp-9r3c-p9vr), whose `JsonConvert` API is actually called from `Program.cs`, and `System.Text.Encodings.Web` 4.5.0 (GHSA-24c2-23r3-8vpr), which is declared but never imported or used. A correct reachability check should flag the former as reachable and the latter as not.

`js_reachability/` is a small JS app (express API, client with vue/svelte/typescript, webpack and babel configs, a coffee script) used to test reachability analysis for npm dependencies. Every vulnerable package is used in exactly one way, so its result shows whether that way of importing is understood. Vulnerable packages that are not direct dependencies are pinned with `overrides` and reached through a package that is used in one specific way. A scan will also report other vulnerable transitive packages (e.g. of `request` or `@babel/*`); only the ones below are part of the test.

| Vulnerable package | Path | Used through | File | Expected |
|---|---|---|---|---|
| `express:4.17.1` | direct | require assigned to a variable | `server/index.js` | reachable |
| `body-parser:1.19.0` | `express:4.17.1` | chain through a required package | `server/index.js` | reachable |
| `qs:6.7.0` | `express:4.17.1` | chain through a required package | `server/index.js` | reachable |
| `moment:2.29.1` | direct | bare import 'x/sub' | `client/index.js` | reachable |
| `jsonwebtoken:8.5.1` | direct | require('x').fn() not assigned | `server/auth.js` | reachable |
| `node-fetch:2.6.0` | direct | dynamic import('x') | `server/report.js` | reachable |
| `marked:4.0.9` | direct | dynamic import(`x`) with template literal | `server/report.js` | reachable |
| `validator:13.6.0` | direct | export { a } from 'x' (typescript) | `client/api/index.ts` | reachable |
| `swagger-ui-dist:3.52.0` | direct | require.resolve('x') | `server/docs.js` | reachable |
| `request:2.88.2` | direct | coffee require 'x' | `scripts/import-feed.coffee` | reachable |
| `dompurify:2.0.7` | direct | .vue <script> | `client/components/Comment.vue` | reachable |
| `axios:0.21.1` | direct | .svelte <script> | `client/components/Chart.svelte` | reachable |
| `loader-utils:2.0.0` | `file-loader:6.2.0` | inline loader '!!file-loader!./logo.png' | `client/index.js` | reachable |
| `postcss:8.4.20` | `css-loader:5.2.7` | webpack config short loader names 'style!css' | `webpack.config.js` | reachable |
| `loader-utils:2.0.0` | `css-loader:5.2.7` | webpack config short loader names 'style!css' | `webpack.config.js` | reachable |
| `browserslist:3.2.8` | `babel-preset-env:1.7.0` | .babelrc preset short name "env" | `client/legacy/.babelrc` | reachable |
| `semver:5.7.1` | `@babel/preset-env:7.12.1` | babel.config.js function, preset '@babel/env' | `babel.config.js` | reachable |
| `lodash:4.17.20` | `babel-plugin-styled-components:2.0.7` | babel.config.js function, plugin 'styled-components' | `babel.config.js` | reachable |
| `lodash:4.17.20` | `babel-plugin-lodash:3.3.4` | package.json "babel" plugin short name "lodash" | `package.json` | reachable |
| `underscore:1.12.0` | direct | only in a line comment (not the first of the file) | `client/legacy/widget.js` | not reachable |
| `jquery:3.4.1` | direct | only in a //= require "x" asset pipeline comment | `client/legacy/widget.js` | not reachable |
| `xml2js:0.4.23` | direct | only in a string, whole package affected | `server/report.js` | reachable |
| `xml2js:0.4.23` | direct (functions: `parseString`) | only in a string, specific CVE functions | `server/report.js` | not reachable |
