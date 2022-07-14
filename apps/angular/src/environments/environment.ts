import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'GameStreaming',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44380',
    redirectUri: baseUrl,
    clientId: 'GameStreaming_App',
    responseType: 'code',
    scope: 'offline_access GameStreaming',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44389',
      rootNamespace: 'GameStreaming',
    },
  },
} as Environment;
