import React from 'react';
import {
  Box,
  Text,
  VStack,
  HStack,
  Badge,
  Avatar,
  Card,
  CardBody,
  useColorModeValue,
} from '@chakra-ui/react';

/**
 * Coach card component to display individual coach information
 * Used in the featured coaches section
 */
const CoachCard = ({ coach }) => {
  const cardBg = useColorModeValue('white', 'gray.700');
  const borderColor = useColorModeValue('gray.200', 'gray.600');

  return (
    <Card
      bg={cardBg}
      border="1px"
      borderColor={borderColor}
      borderRadius="xl"
      overflow="hidden"
      transition="all 0.3s"
      _hover={{
        transform: 'translateY(-4px)',
        boxShadow: 'xl',
        borderColor: 'brand.300',
      }}
      cursor="pointer"
    >
      <CardBody p={6}>
        <VStack spacing={4} align="start">
          {/* Coach Avatar and Basic Info */}
          <HStack spacing={4}>
            <Avatar
              size="lg"
              name={coach.name}
              src={coach.profileImage}
              bg="brand.500"
            />
            <VStack align="start" spacing={1}>
              <Text fontWeight="bold" fontSize="lg" color="gray.800">
                {coach.name}
              </Text>
              <Text fontSize="sm" color="gray.600">
                {coach.specialization}
              </Text>
              <HStack spacing={2}>
                <Badge colorScheme="brand" variant="subtle" fontSize="xs">
                  {coach.experience} years
                </Badge>
                <Badge colorScheme="green" variant="subtle" fontSize="xs">
                  {coach.clientCount}+ clients
                </Badge>
              </HStack>
            </VStack>
          </HStack>

          {/* Coach Description */}
          <Text fontSize="sm" color="gray.700" lineHeight="tall">
            {coach.description}
          </Text>

          {/* Specialties */}
          <Box>
            <Text fontSize="sm" fontWeight="semibold" color="gray.800" mb={2}>
              Specialties:
            </Text>
            <HStack spacing={2} flexWrap="wrap">
              {coach.specialties?.map((specialty, index) => (
                <Badge
                  key={index}
                  colorScheme="accent"
                  variant="outline"
                  fontSize="xs"
                  px={2}
                  py={1}
                >
                  {specialty}
                </Badge>
              ))}
            </HStack>
          </Box>

          {/* Success Rate or Rating */}
          <HStack justify="space-between" w="full" pt={2}>
            <VStack align="start" spacing={0}>
              <Text fontSize="xs" color="gray.600">
                Success Rate
              </Text>
              <Text fontSize="sm" fontWeight="bold" color="green.500">
                {coach.successRate}%
              </Text>
            </VStack>
            <VStack align="end" spacing={0}>
              <Text fontSize="xs" color="gray.600">
                Rating
              </Text>
              <HStack spacing={1}>
                <Text fontSize="sm" fontWeight="bold" color="brand.500">
                  {coach.rating}
                </Text>
                <Text fontSize="xs" color="gray.600">
                  ⭐
                </Text>
              </HStack>
            </VStack>
          </HStack>
        </VStack>
      </CardBody>
    </Card>
  );
};

export default CoachCard;
