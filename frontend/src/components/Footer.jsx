import React from 'react';
import {
  Box,
  Container,
  Stack,
  Text,
  Link,
  HStack,
  VStack,
  Divider,
  useColorModeValue,
} from '@chakra-ui/react';

/**
 * Footer component with links and company information
 * Clean design consistent with the overall theme
 */
const Footer = () => {
  const bg = useColorModeValue('white', 'gray.800');
  const borderColor = useColorModeValue('gray.200', 'gray.700');

  return (
    <Box
      bg={bg}
      borderTop="1px"
      borderColor={borderColor}
      mt={20}
    >
      <Container maxW="7xl" py={12}>
        <Stack spacing={8}>
          {/* Main footer content */}
          <Stack
            direction={{ base: 'column', md: 'row' }}
            spacing={{ base: 8, md: 16 }}
            justify="space-between"
          >
            {/* Company Info */}
            <VStack align="start" spacing={4} maxW="300px">
              <Text
                fontSize="lg"
                fontWeight="bold"
                color="brand.500"
                letterSpacing="tight"
              >
                Fitness Tracker
              </Text>
              <Text fontSize="sm" color="gray.600" lineHeight="tall">
                Transform your body with professional bodybuilding coaching. 
                Get personalized training programs and expert guidance to reach your fitness goals.
              </Text>
            </VStack>

            {/* Quick Links */}
            <Stack direction={{ base: 'column', sm: 'row' }} spacing={8}>
              <VStack align="start" spacing={3}>
                <Text fontWeight="semibold" color="gray.800">
                  Product
                </Text>
                <VStack align="start" spacing={2}>
                  <Link
                    fontSize="sm"
                    color="gray.600"
                    _hover={{ color: 'brand.500' }}
                    transition="color 0.2s"
                  >
                    Features
                  </Link>
                  <Link
                    fontSize="sm"
                    color="gray.600"
                    _hover={{ color: 'brand.500' }}
                    transition="color 0.2s"
                  >
                    Pricing
                  </Link>
                  <Link
                    fontSize="sm"
                    color="gray.600"
                    _hover={{ color: 'brand.500' }}
                    transition="color 0.2s"
                  >
                    Programs
                  </Link>
                </VStack>
              </VStack>

              <VStack align="start" spacing={3}>
                <Text fontWeight="semibold" color="gray.800">
                  Company
                </Text>
                <VStack align="start" spacing={2}>
                  <Link
                    fontSize="sm"
                    color="gray.600"
                    _hover={{ color: 'brand.500' }}
                    transition="color 0.2s"
                  >
                    About
                  </Link>
                  <Link
                    fontSize="sm"
                    color="gray.600"
                    _hover={{ color: 'brand.500' }}
                    transition="color 0.2s"
                  >
                    Coaches
                  </Link>
                  <Link
                    fontSize="sm"
                    color="gray.600"
                    _hover={{ color: 'brand.500' }}
                    transition="color 0.2s"
                  >
                    Contact
                  </Link>
                </VStack>
              </VStack>

              <VStack align="start" spacing={3}>
                <Text fontWeight="semibold" color="gray.800">
                  Resources
                </Text>
                <VStack align="start" spacing={2}>
                  <Link
                    fontSize="sm"
                    color="gray.600"
                    _hover={{ color: 'brand.500' }}
                    transition="color 0.2s"
                  >
                    Blog
                  </Link>
                  <Link
                    fontSize="sm"
                    color="gray.600"
                    _hover={{ color: 'brand.500' }}
                    transition="color 0.2s"
                  >
                    Guides
                  </Link>
                  <Link
                    fontSize="sm"
                    color="gray.600"
                    _hover={{ color: 'brand.500' }}
                    transition="color 0.2s"
                  >
                    Support
                  </Link>
                </VStack>
              </VStack>
            </Stack>
          </Stack>

          <Divider borderColor={borderColor} />

          {/* Bottom section */}
          <HStack
            justify="space-between"
            align="center"
            direction={{ base: 'column', md: 'row' }}
            spacing={4}
          >
            <Text fontSize="sm" color="gray.600">
              © 2025 Fitness Tracker. All rights reserved.
            </Text>
            <HStack spacing={6}>
              <Link
                fontSize="sm"
                color="gray.600"
                _hover={{ color: 'brand.500' }}
                transition="color 0.2s"
              >
                Privacy Policy
              </Link>
              <Link
                fontSize="sm"
                color="gray.600"
                _hover={{ color: 'brand.500' }}
                transition="color 0.2s"
              >
                Terms of Service
              </Link>
            </HStack>
          </HStack>
        </Stack>
      </Container>
    </Box>
  );
};

export default Footer;
