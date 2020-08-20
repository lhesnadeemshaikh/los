export const environment = {
  production: true,
  application: {
    name: 'ReverseLOS',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44381',
    clientId: 'ReverseLOS_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'ReverseLOS',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44323',
    },
  },
  localization: {
    defaultResourceName: 'ReverseLOS',
  },
};
